using AIC_LAB5.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AIC_LAB5.Client.MVVM.Model
{
    public class StudentForm: INotifyPropertyChanged
    {
        private string _name = "Имя";
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _group = "Группа";
        public string Group
        {
            get { return _group; }
            set 
            { 
                _group = value; 
                OnPropertyChanged(); 
            }
        }


        private string _speciality = "Специальность";
        public string Speciality
        {
            get => _speciality;
            set
            {
                _speciality = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Создает объект студента из формы.
        /// </summary>
        /// <returns></returns>
        public Student BuildStudent()
        {
            return new Student { Name = this.Name, Speciality = this.Speciality, Group = this.Group };
        } 

        /// <summary>
        /// Устанавливает значения полей формы на значения полей выделеного в таблице студента.
        /// </summary>
        /// <param name="student"></param>
        public void SetFormFields(Student student)
        {
            this.Name = student.Name;
            this.Speciality = student.Speciality;
            this.Group = student.Group;
        }

        public bool IsFormValid()
        {
            if(this.Name.Length > 0 && this.Group.Length > 0)
            {
                return true;
            }
            return false;
        }

        #region NotifyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        #endregion


    }
}
