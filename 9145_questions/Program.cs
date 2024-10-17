using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9145_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        static Node<int> Arr2List(int[] arr)
        {
            Node<int> lst = new Node<int>(arr[0]);
            Node<int> last = lst;

            for (int i = 1; i < arr.Length; i++)
            {
                last.SetNext(new Node<int>(arr[i]));
                last = last.GetNext();
            }

            return lst;
        }

        // שאלה 1: מציאת הערך השני הכי גדול ברשימה
        // FindSecondLargest
        // param : Node<int>
        // return : int
        // examples:
        // param : -> 2, 7, 5, 4, 8, 2, 9  ==> return : 8
        // param : -> 2 ==> return int.MinValue
        // param : -> null ==> return int.MinValue
        static int FindSecondLargest(Node<int> head)
        {
            return 0;
        }

        //שאלה 2: מציאת הערך האמצעי ברשימה מקושרת
        // FindMiddleNode
        // param : Node<int>
        // return : int
        // examples:
        // param : -> 2, 7, 5, 4, 8, 2, 9  ==> return : 4
        // param : -> 2, 7, 5, 4, 8, 2     ==> return : 5 (first of 2 middle values)
        // param : -> null                 ==> return : int.MinValue
        // יש לעבור על הרשימה רק פעם אחת
        // אין להשתמש במבני נתונים נוספים

        static int FindMiddleNode(Node<int> head)
        {
            return 0;
        }

        //שאלה 3: מחיקת כל האיברים הקטנים מערך נתון
        // DeleteSmallerThanNum
        // param1 : Node<int>, param2: num
        // return : Node<int>
        // examples:
        // param1 : -> 2, 7, 5, 4, 8, 2, 9  param2: 6 ==> return : ->7,8,9
        // param1 : -> null, ==> return : null

        // יש לעבור על הרשימה רק פעם אחת
        // אין להשתמש במבני נתונים נוספים
        //יש לשנות את הרשימה המקורית ולא ליצור רשימה חדשה

        static Node<int> DeleteSmallerThanNum(Node<int> head, int num)
        {
            return null;
        }

        //שאלה 4: סינון כפילויות ברשימה מקושרת
        //שאלה קשה
        // param  : Node<int>
        // return : Node<int>
        // examples:
        // param : ->2,2,7,5,5,5,4,8,2,9,9,9,9 ==>return: ->2,7,5,4,8,2,9
        // param : -> null, ==> return : null
        // param : ->1, ==> return : ->1

        // יש לעבור על הרשימה רק פעם אחת
        // אין להשתמש במבני נתונים נוספים
        //יש לשנות את הרשימה המקורית ולא ליצור רשימה חדשה
        //tip: use while in while

        static Node<int> RemoveDuplicates(Node<int> head)
        {
            return null;
        }

        //שאלה 5: מציאת קשר בין שני איברים ברשימה
        // AreConnected, check if 2 values are connected in a list
        // param1  : Node<int>
        // param2  : int
        // param3  : int
        // return  : bool
        // examples:
        // param1 : ->1,5,4,9,2  param2: 5   param3: 4   => return: true
        // param1 : ->1,5,4,9,2  param2: 9   param3: 4   => return: true
        // param1 : ->1,5,4,9,2  param2: 9   param3: 5   => return: false
        // יש לעבור על הרשימה רק פעם אחת
        // אין להשתמש במבני נתונים נוספים
        //יש לשנות את הרשימה המקורית ולא ליצור רשימה חדשה
        public bool AreConnected(Node<int> head, int value1, int value2)
        {
            return false;
        }

        //שאלה 6: מציאת הרצף הארוך ביותר ברשימה מקושרת
        // LongestSeq
        // param : Node<int>
        // return : int
        // examples:
        // param : ->2,2,7,5,5,5,4,8,2,9,9,9,9 ==>return: 4
        // param : ->null ==> return: 0
        // param : ->3    ==> return: 1
        // אין להשתמש במבני נתונים נוספים פרט לרשימה המקושרת

        static int LongestSeq(Node<int> head)
        {
            return 0;
        }

        //שאלה 7: בניית רשימה מקושרת מהספרות של מספר
        // BuildListFromNumber
        // param : int
        // return : Node<int>
        // examples:
        // param : 123 ==> return : ->3,2,1
        // param : 0 ==> return: ->null
        // הפעולה צריכה לעבור על הספרות של המספר אחת אחת ולבנות את הרשימה
        // אין להשתמש במבני נתונים נוספים פרט לרשימה המקושרת
        // suggestion: use dummy node
        static Node<int> BuildListFromNumber(int number)
        {
            return null;
        }


    }
}
