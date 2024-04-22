using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class PriorityQueue
    {
        List<Patient> patients = new List<Patient>();
        private int getParent(int index)
        {
            return  (index - 1) / 2;
        }
        private int getLeftChild(int index) 
        {
            return  (index*2)+1;
        }
        private int getRightChild(int index)
        {
            return  (index*2)+2;
        }
        private void swap(int index1 , int index2)
        {
            Patient temp = patients[index1];
            patients[index1] = patients[index2];
            patients[index2] = temp;
        }
        private void upHeap(int index)
        {
            if (index == 0)
            {
                return;
            }
            int parent = getParent(index);
            if (patients[index].urgency > patients[parent].urgency)
            {
                swap(parent, index);
            }
            upHeap(parent);
        }
        private void downHeap(int index)
        {
            int left = getLeftChild(index);
            int right = getRightChild(index);
            int max = index;
            if (left < patients.Count && patients[left].urgency > patients[max].urgency)
            {
                max = left;
            }
            if(right < patients.Count && patients[right].urgency > patients[max].urgency)
            {
                max = right;
            }
            if(max != index)
            {
                swap(index, max);
                downHeap(max);
            }
            

        }
        public void insert(Patient patient)
        {
            patients.Add(patient);
            upHeap(patients.Count - 1);
        }
        public Patient remove()
        {
            if (patients.Count == 0)
            {
                throw new Exception("The List is Empty");
            }
            Patient temp = patients[0];
            patients[0] = patients[patients.Count-1];
            patients.RemoveAt(patients.Count-1);
            if(patients.Count > 1)
            {
                downHeap(0);
            }
            return temp;

        }
        public Patient peek() 
        {
            return patients[0];
        }
    }
}
