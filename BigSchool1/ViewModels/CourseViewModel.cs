using BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool1.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập Place")]
        public string Place { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập Date")]
        [FutureDate(ErrorMessage ="Ngày phải lớn hơn ngày hiện tại")]
        public string Date { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập Time")]
        [ValidTime(ErrorMessage ="Nhập đúng định dạng giờ:phút")]
        public string Time { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập Category")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}