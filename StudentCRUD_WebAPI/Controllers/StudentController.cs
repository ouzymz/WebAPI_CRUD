using BUSSINESLayer.Abstract;
using BUSSINESLayer.Concrete;
using DATALayer.Abstract;
using DATALayer.EF;

using ENTITYLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentCRUD_WebAPI.Controllers
{
    public class StudentController : ControllerBase
    {
        StudentManager _studentService = new StudentManager(new EFStudentDal());

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.TGetAll());
        }

        [HttpGet]
        [Route("GetStudentsById")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(_studentService.TGetProductById(id));
        }

        [HttpPost]
        [Route("AddNewStudent")]

        public IActionResult AddNewStudent(Student newStudent) 
        {
            _studentService.TCreate(newStudent);
            return Ok(newStudent);
        }
        [HttpPut]
        [Route("UpdateStudent")]

        public IActionResult UpdateStudent(Student updatedStudent)
        {
            _studentService.TUpdate(updatedStudent);
            return Ok(updatedStudent);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.TDelete(id);
            return Ok();
        }


    }
}
