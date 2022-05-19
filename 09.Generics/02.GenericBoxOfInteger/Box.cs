using System;
using System.Collections.Generic;
using System.Text;


    public class Box<T>
    {
      private  List<T> items;
        public List<T> Items 
        { 
            get 
            {
                return items;
            }  
        }
        public Box()
        {
            items = new List<T>();
        }
       public void AddItem(T item)
        {
            items.Add(item);
        }
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append($"{item.GetType()}: {item}\n");
            }
            return sb.ToString();
        }
    
}
