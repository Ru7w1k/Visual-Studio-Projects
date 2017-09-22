using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFFirst
{
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        List<Student> GetStudent();
        
        [OperationBehavior]
        Student GetStudentById(int id);
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
