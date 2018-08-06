using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree {
    class BiTree {
        int? value;
        BiTree left;
        BiTree right;

        // Insert - indsætter en værdi i en binær træ struktur. 
        public void Insert(int val) {
            if (this.value == null){
                Console.WriteLine("Første knude");
                this.value = val;
                return;
            }
            else if (val < this.value) {
                if(left == null) {
                    left = new BiTree();
                    left.value = val;
                } else {
                    left.Insert(val);
                }
            }

            else if (val > this.value) {
                if(right == null) {
                    right = new BiTree();
                    right.value = val;
                } else {
                    right.Insert(val);
                }
            } else {
                Console.WriteLine("ERROR: Insert value doesnt match anything");
            }
        }

        // min() - Printer det mindste tal i datastrukturen
        public int min() {
            if (left == null) {
                return (int)this.value;
            } else {
                return left.min();
            }
        }

        // max() - Printer det højeste tal i datastrukturen
        public int max() {
            if (right == null) {
                return (int)this.value;
            } else {
            return right.max();

            }
        }

        // find() - Checks if a number is inserted in the datastructure
        public bool find(int val) {
            if (this.value == val) {
                return true;
            }else if (val < this.value && left != null){
                return left.find(val);
            }else if(val > this.value && right != null) {
                return right.find(val);
            } else {
                return false;
            }
        }
    }
}
