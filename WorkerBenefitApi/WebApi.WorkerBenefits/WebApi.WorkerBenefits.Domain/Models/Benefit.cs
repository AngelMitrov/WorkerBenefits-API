using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.Domain.Enums;

namespace WebApi.WorkerBenefits.Domain.Models
{
    public class Benefit
    {
        public Benefit()
        {
            if(Worker.Position == WorkerPosition.Intern)
            {
                Benefits.Add(AvailableBenefits.Food);
                Benefits.Add(AvailableBenefits.Paid_Internship);
            } else if(Worker.Position == WorkerPosition.Junior)
            {
                Benefits.Add(AvailableBenefits.Gym_membership);
                Benefits.Add(AvailableBenefits.Health_insurance);
                Benefits.Add(AvailableBenefits.Family_leave);
                Benefits.Add(AvailableBenefits.Remote_work);
                Benefits.Add(AvailableBenefits.Paid_time_off);
                Benefits.Add(AvailableBenefits.Retirement_plan);
            }
            else
            {
                Benefits.Add(AvailableBenefits.On_site_gym);
                Benefits.Add(AvailableBenefits.Health_insurance);
                Benefits.Add(AvailableBenefits.Dental_insurance);
                Benefits.Add(AvailableBenefits.Vision_insurance);
                Benefits.Add(AvailableBenefits.Family_leave);
                Benefits.Add(AvailableBenefits.Remote_work);
                Benefits.Add(AvailableBenefits.Unlimited_paid_time_off);
                Benefits.Add(AvailableBenefits.Retirement_plan);
            }
        }
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public List<AvailableBenefits> Benefits { get; set; }
    }
}
