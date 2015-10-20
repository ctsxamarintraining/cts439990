using System;

namespace Day6Three
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stack stack = new Stack();
			stack.push (1);
			stack.push (2);
			stack.push (3);
			stack.push (4);
			Console.WriteLine ("The top element is " + stack.peek ());
			Console.WriteLine ("The popped element is " + stack.pop ());
			Console.WriteLine ("The popped element is " + stack.pop ());
			Console.WriteLine ("The top element is " + stack.peek ());
			Queue queue = new Queue();
			queue.enqueue (1);
			queue.enqueue (2);
			queue.enqueue (3);
			queue.enqueue (4);

			Console.WriteLine ("The dequeued element is " + queue.dequeue ());
			Console.WriteLine ("The dequeued element is " + queue.dequeue ());
		}
	}

	class Stack{
		int[] dataArray = new int[10];
		int top=-1;
		public void push(int ele){
			top++;
			if (top < dataArray.Length) {
				dataArray [top] = ele;
				Console.WriteLine (ele + "pushed to stack");
			} else {
				Console.WriteLine ("Stack OverFlow");
			}
		}
		public int pop(){
			top--;
			if (top >=0) {
				return dataArray [top];
			} else {

				Console.WriteLine ("Stack UnderFlow");
				return -1;
			}
		}
		public int peek(){

			if (top >=0) {
				return dataArray [top];
			} else {
				Console.WriteLine ("No elements");
				return -1;
			}
		}
	}

	class Queue{
		int[] dataArray = new int[10];
		int front=-1;
		int rear=-1;
		public void enqueue(int ele){
			rear++;
			if (rear < dataArray.Length) {
				dataArray [rear] = ele;
				Console.WriteLine (ele + "enqueued to queue");
			} else {
				Console.WriteLine ("Queue OverFlow");
			}
		}
		public int dequeue(){
			front++;
			if (front < dataArray.Length) {
				return dataArray [front];
			} else {
				Console.WriteLine ("Queue UnderFlow");
				return -1;
			}
		}

	}
}


