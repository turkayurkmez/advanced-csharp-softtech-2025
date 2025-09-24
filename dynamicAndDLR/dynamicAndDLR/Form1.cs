using Newtonsoft.Json;
using System.Text.Json;

namespace dynamicAndDLR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDynamicKeyword_Click(object sender, EventArgs e)
        {
            dynamic value = getData();
            MessageBox.Show(value.ToUpper());

            //value = 8;
            //MessageBox.Show(value.ToUpper());

        }

        private dynamic getData()
        {
            throw new NotImplementedException();
        }

        private dynamic process(string value)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(value);

            string userName = jsonObject.user.name;

            return new
            {
                UserName = jsonObject.user.name,
                Age = jsonObject.user.age,
                Skills = jsonObject.user.skills,
                TimeStamp = jsonObject.user.timestamp,

            };
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonResult = """
            {
               "user":{
                 "name":"Türkay",
                 "age":45,
                 "skills":["C#","Pyhton","JS"]
               },
               "timestamp":"2025-09-24"
            }
            """;

            dynamic output = process(jsonResult);
            MessageBox.Show($"{output.UserName} kullanýcýsý, {output.Age} yaþýnda ve yetenekleri: {(string.Join(", ", output.Skills))}");
        }
    }
}
