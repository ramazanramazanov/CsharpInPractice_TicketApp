using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystemApp.Core
{
   public static class FormExtentions
    {
        
        public static void DisplayError(this Form form, IEnumerable<ValidationResult> results, Control applyTo)
        {
            foreach (var item in results)
            {
                applyTo.Text += item.ErrorMessage + "\n";
            }
        }
        public static bool IsValid(this Form form,object obj,Control errorOn)
        {
            EntityValidator entityValidator = new EntityValidator();
            IEnumerable<ValidationResult> validationResults = entityValidator.Validate(obj);


            if (validationResults!=null)
            {
                DisplayError(form,validationResults, errorOn);
                return false;
            }
            else
            return true;
        }

        public static T MapToDataModel<T>(this Form form)
        {
            var typeProperties = typeof(T).GetProperties();
            var allText = form.Controls.OfType<GroupBox>().FirstOrDefault().Controls.OfType<TextBox>();
            T obj = Activator.CreateInstance<T>();
            foreach (var item in typeProperties)
            {
                string propertyValue = allText.Where(x => x.Name.Contains(item.Name)).FirstOrDefault()?.Text;
                item.SetValue(obj, propertyValue);
            }
            return obj;
        }
        public static T MapToDataModell<T>(this Form form)
        {
            var propertyType = typeof(T).GetProperties();
            var alltext = form.Controls.OfType<UserControl>().FirstOrDefault()
                                .Controls.OfType<GroupBox>().FirstOrDefault()
                                  .Controls.OfType<TextBox>();
            T obj = Activator.CreateInstance<T>();
            foreach (var item in propertyType)
            {
               string propertyValue= alltext.Where(x => x.Name.Contains(item.Name)).FirstOrDefault()?.Text;
                item.SetValue(obj, propertyValue);
            }
            return obj;
        }
        public static void ReDirectTo<T>(this Form form)where T:Form
        {
           T createdForm= Activator.CreateInstance<T>();
            form.Hide();
            createdForm.ShowDialog();
        }

        public static void ReDirectTo(this Form form,Form toForm) 
        {           
            form.Close();
            toForm.Show();
        }
    }

   

    

}
