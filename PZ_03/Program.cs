namespace PZ_03
{
    using System;
    using System.Collections.Generic;

    public enum PatientCondition
    {
        Satisfactory,
        Moderate,
        Severe
    }

    public class Patient
    {/*Создать перечисление для состояния пациента (удовлетворительное
средней тяжести, тяжелое)
Создать класс пациента (состояние, дата поступления, дата выписки (на начало создания объекта пустая), жалобы, диагноз, назначенное лечение)
Создать список пациентов. Заполнить его программно через специальный метод-генератор


Создать статичный класс приёмного отделения со статичными методами для:
1. Добавления нового пациента
2. Изменения состояния пациента
3. Выписки пациента
4. Вывода всех пациентов отделения
5. Вывод пациентов отделения по тяжести состояния (с цветовой идентификацией для разных состояний)
6. Вывод пациентов, поступивших на конкретную дату
7. Вывод пациентов, выписанных из отделения*/
        public PatientCondition Condition;
        public DateTime AdmissionDate;
        public DateTime? DischargeDate;
        public string Complaints;
        public string Diagnosis;
        public string Treatment;

        public Patient(PatientCondition condition, DateTime admissionDate,
                      string complaints, string diagnosis, string treatment)
        {
            Condition = condition;
            AdmissionDate = admissionDate;
            Complaints = complaints;
            Diagnosis = diagnosis;
            Treatment = treatment;
        }
    }

    public static class AdmissionDepartment
    {
        public static List<Patient> Patients = new List<Patient>();

        public static void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public static void UpdateCondition(int index, PatientCondition newCondition)
        {
            if (index >= 0 && index < Patients.Count)
                Patients[index].Condition = newCondition;
        }

        public static void DischargePatient(int index, DateTime dischargeDate)
        {
            if (index >= 0 && index < Patients.Count)
                Patients[index].DischargeDate = dischargeDate;
        }

        public static void PrintAll()
        {
            Console.WriteLine("Все пациенты:");
            foreach (var p in Patients)
                Console.WriteLine($"- {p.Diagnosis}, состояние: {p.Condition}");
        }

       
    }

    class Program
    {
        static void Main()
        {
            // Добавляем 3 тестовых пациента
            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Moderate,
                DateTime.Today,
                "Головная боль",
                "Мигрень",
                "Обезболивающее"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Severe,
                DateTime.Today.AddDays(-1),
                "Температура",
                "Пневмония",
                "Антибиотики"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Satisfactory,
                DateTime.Today,
                "Кашель",
                "ОРВИ",
                "Сироп"
            ));

         
        }
    }
}
