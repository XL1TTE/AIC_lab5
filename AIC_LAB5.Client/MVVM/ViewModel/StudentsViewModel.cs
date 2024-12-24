using AIC_LAB5.Client.Commands;
using AIC_LAB5.Client.MVVM.Model;
using AIC_LAB5.Client.MVVM.View;
using AIC_LAB5.DAL.Repository;
using AIC_LAB5.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ViewModel;

namespace AIC_LAB5.Client.MVVM.ViewModel
{
    public class StudentsViewModel : ViewModelBase<StudentView>
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();

        public IEntityRepository<Student> StudentRepository { get; set; } = new EntityFramework_StudentRepository();


        public StudentForm StudentForm { get; set; } = new StudentForm();

        private Student? _selectedStudent;
        public Student? SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                if(_selectedStudent != null)
                {
                    StudentForm.SetFormFields(_selectedStudent);
                }
            }
        }

        #region Commands
        public RelayCommand CreateStudent { get; set; } = null!;
        public RelayCommand DeleteStudent { get; set; } = null!;
        public RelayCommand UpdateStudent { get; set; } = null!;

        private void InitializeCommands()
        {
            CreateStudent = new RelayCommand(a => { StudentRepository.Create(StudentForm.BuildStudent()); UpdateStudentsData(); }, p => StudentForm.IsFormValid());
            DeleteStudent = new RelayCommand(a => { StudentRepository.Delete(SelectedStudent); UpdateStudentsData(); }, p => SelectedStudent != null);
            UpdateStudent = new RelayCommand(a => { StudentRepository.Update(SelectedStudent, StudentForm.BuildStudent()); UpdateStudentsData(); }, p => (SelectedStudent != null && StudentForm.IsFormValid()));
        }
        #endregion

        private void UpdateStudentsData()
        {
            var all_students = StudentRepository.ReciveAll();

            
            Students.Clear();


            foreach (var student in all_students)
            {
                Students.Add(student);
            }
        }

        public StudentsViewModel() : base()
        {
            InitializeCommands();
            UpdateStudentsData();
        }
    }
}
