namespace WhatShouldWeEat.Controllers.dto
{
    public class TestDTO
    {
        private int id { get; set; }

        private string _text;

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public TestDTO(int id, string text)
        {
            this.id = id;
            this.text = text;
        }
    }
}