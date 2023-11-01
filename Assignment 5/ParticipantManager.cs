using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class ParticipantManager
    {
        //The responsibility of this class is to maintain and handle the collection of participants
        //add a new participantObj object, edit or delete an existing object, erturn a participantObj at a certain position
        //and return a list of strings representing each participantObj
        //This class serves as a container class for objects of participants. Use a List<> to stpre the participants
        //added via the user interface.
        #region Fields area
        private List<Participant> participants;

        #endregion

        #region Manual methods
        public ParticipantManager()//done
        {
            //create new object everytimes ParticipantManager class is instantiated.
            participants = new List<Participant>();
        }
        public bool AddParticipant(Participant participantIn)//done
        {
            bool validAdd = false;

            if (participantIn != null)
            {
                participants.Add(participantIn);
                validAdd = true;
            }

            return validAdd;
        }
        public bool AddParticipant(string firstName, string lastName, Address adressIn)//done
        { 
            //Add the value into an object pass to Participant class
            Participant participant = new Participant(adressIn, lastName, firstName);
            //Then add it to a list by using list method
            participants.Add(participant);

            return true;
        }
        public bool ChangeParticipantAt(Participant participantIn, int index)//done
        {
            bool validChange = false;

            if ((CheckIndex(index)) && (participantIn != null))
            {
                participants[index] = participantIn;
                validChange = true;
            }

            return validChange;
        }
        private bool CheckIndex(int index)//done
        { 
            //checking if an index is within the bound of the list
            return index >= 0 && index < participants.Count;
        }
        public bool DeleteParticipantAt(int index) //done
        {
            bool validDelete = false;

            if (CheckIndex(index))
            {   
                participants.RemoveAt(index);
                validDelete = true;
            }

            return validDelete;
        }
        public Participant GetParticipantAt(int index)//done
        {
            //will get a participantObj at specified index from Participant class.
            if (CheckIndex(index))
            {
                Participant original =  participants[index]; //send an index in a original object
                Participant copy = new Participant(original); // return a copy instead, but still hold the same "get recipe"
               return copy;
            }

            return null;
        }
        public string[] GetParticipantsInfo()//done
        {
            //return an array of string where each string is thre return value of
            //a call to the participantObj object's Tostring().

            string[] arrayOut = new string[participants.Count];

            for (int i = 0; i < participants.Count; i++)
            {
                arrayOut[i] = participants[i].ToString();
            }

            return arrayOut;
        }

        #endregion

        #region Property area
        public int Count //done
        { get { return participants.Count; } } //return the count of the list
        #endregion

    }
}
