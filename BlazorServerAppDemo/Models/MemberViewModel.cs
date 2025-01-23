using System;

namespace BlazorServerAppDemo.Models
{
    [Serializable]
    public class MemberViewModel
    {
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
