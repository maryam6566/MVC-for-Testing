using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using N_Layer_selectunit;


namespace DAL
{
     public class CourseAdapter:BaseAdapter<daselectunit.CourseDataTable>
     {
         
         const string _QUERY_INSERT_Course = @"INSERT INTO Course(course id,course name,branch id,teacher name,hour)VALUES(pcourse id,pcourse name,pbranch id,pteacher name,phour)";
         const string _QUERY_DELETE_Course_BY_course id=@"DELETE FROM Course WHERE Course id=pcourse id"

         public bool Insert(string pcourse Id,string pcourse name,string pbranch id,string pteacher id,string phour)
           {
              OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pcourse id",pcourse id),new OleDbParameter("pcourse name",pcourse name),new OleDbParameter("pbranch id",pbranch id),new OleDbParameter("pteacher name",pteacher name),new OleDbParameter("phour",phour)};
              return base.execute_Command_NonQuery(_QUERY_INSERT_Course,person,p);
           }

         public bool Delete_By_course id(string pcourse id)
            {
               OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pcourse id",pcourse id)};
               return base.execute_Command_NonQuery(_QUERY_DELETE_Course_By_course id,p);
            }
       }
}
 