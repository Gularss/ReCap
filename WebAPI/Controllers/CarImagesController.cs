using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("add")]
        //Aşağıda yoruma çekilen alanı açtığımda metoda parametre olarak Image ifadesini göndermemiz gerekmektedir.
        public IActionResult Add(/*[FromForm(Name = ("Image"))] */IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        //Aşağıda yoruma çekilen alanı açtığımda metoda parametre olarak Image ifadesini göndermemiz gerekmektedir.
        public IActionResult Update(/*[FromForm(Name = ("Image"))] */IFormFile file, [FromForm] CarImage carImage)
        {
            var updatedCarImage = _carImageService.Get(carImage.Id).Data;
            var result = _carImageService.Update(file, updatedCarImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            CarImage deletedCarImage = _carImageService.Get(carImage.Id).Data;
            var result = _carImageService.Delete(deletedCarImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("get")]
        public IActionResult Get(int carImageId)
        {
            var result = _carImageService.Get(carImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcarimagesbycarid")]
        public IActionResult GetCarImagesByCarId(int carId)
        {
            var result = _carImageService.GetCarImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
