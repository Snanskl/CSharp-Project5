using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    partial class EventManager
    {
        //this class area of responsibility is to handle the event itself.  
        #region Fields area
        private double costPerPerson = 0;
        private double feePerPerson = 0;
        private ParticipantManager participantManager = new ParticipantManager();
        private string title = string.Empty;
        #endregion

        #region Methods area
        public EventManager()//done
        {
            participantManager = new ParticipantManager(); //This class will have an access to Manager class
        }
        public double CalcTotalCost()//done
        {
            return participantManager.Count * costPerPerson;
        }
        public double CalcTotalFees()//done
        {
            return participantManager.Count * feePerPerson;
        }

        #endregion

        #region Property area
        public double CostPerPerson//done
        {
            get { return costPerPerson; }
            set 
            {
                if (value >= 0.0)
                {
                    costPerPerson = value;
                }
            }
        }
        public double FeePerPerson//done
        {
            get { return feePerPerson; }
            set 
            {
                if (value >= 0.0)
                {
                    feePerPerson = value;
                }
            }
        }
        public ParticipantManager Participant //done
        {
            //This property is neccessary for the MainForm to be able to get
            //access to the methods of the ParticipantManager
            get { return participantManager; }
            //passing the reference to the ParticipantManager
        }
        public string Title //done
        {
            get { return title; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
            }
        }

        #endregion



























    }
}
