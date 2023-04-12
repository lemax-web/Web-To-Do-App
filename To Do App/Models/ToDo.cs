using System;
using System.ComponentModel.DataAnnotations;
using TodoApp.Models;

namespace TodoApp.Models
{
    public class ToDo
    {
        [Key]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }



        public List<ToDo> GetTodoList()
        public List<ToDo> getTodoList()
        {
            List<ToDo> todos = new List<ToDo>();
            todos.Add(new ToDo { Title = "Swimming", IsCompleted = true });
            todos.Add(new ToDo { Title = "Play chess", IsCompleted = false });
            todos.Add(new ToDo { Title = "Watch Movies", IsCompleted = true });
            todos.Add(new ToDo { Title = "Worship", IsCompleted = false });
            todos.Add(new ToDo { Title = "Lecture", IsCompleted = false });
            todos.Add(new ToDo { Title = "Meal time", IsCompleted = true });

            return todos;
        }


        public List<ToDo> getIsnotCompletedList()
        {

            List<ToDo> isNotCompletedList = new List<ToDo>();
            foreach (ToDo todo in new ToDo().getTodoList())
            {
                if (ToDo.IsCompleted == false)
                {
                    isNotCompletedList.Add(todo);
                }
            }
            return isNotCompletedList;
        }

    }
}
