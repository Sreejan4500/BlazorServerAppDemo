using System;

namespace BlazorServerAppDemo.Data
{
    public class Member
    {
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
