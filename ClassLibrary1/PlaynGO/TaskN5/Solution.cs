using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.PlaynGO.TaskN5
{
	//We need an function that can be called on each tick of the game. Create a function that each time it’s invoked moves one object, passed as a parameter, closer to another object, also passed as a parameter, using the two objects x and y properties.
	public interface IMovable
	{
		double x { get; set; }
		double y { get; set; }
	}

	public class MavableObj : IMovable
	{
		public double x { get; set; }
		public double y { get; set; }
	}

	public class Mover
	{
		public double Speed { get; set; }

		public void MoveCloser(IMovable movingObj, IMovable moveToObj)
		{
			double pathLength = Math.Sqrt((movingObj.x - moveToObj.x) * (movingObj.x - moveToObj.x) + (movingObj.y - moveToObj.y) * (movingObj.y - moveToObj.y));

			double pathIncreament = Speed / pathLength;

			double deltax = Math.Abs(movingObj.x - moveToObj.x) * pathIncreament;
			double deltay = Math.Abs(movingObj.y - moveToObj.y) * pathIncreament;

			if (moveToObj.x > movingObj.x)
			{
				movingObj.x += deltax;
			}
			else
			{
				movingObj.x -= deltax;
			}

			if (moveToObj.y > movingObj.y)
			{
				movingObj.y += deltay;
			}
			else
			{
				movingObj.y -= deltay;
			}

			//double pathLength = Math.Sqrt((movingObj.x - moveToObj.x) * (movingObj.x - moveToObj.x) + (movingObj.y - moveToObj.y) * (movingObj.y - moveToObj.y));

			//double pathIncreament = Speed / pathLength;

			//if (pathIncreament > 1)
			//{
			//	movingObj.x = moveToObj.x;
			//	movingObj.y = moveToObj.y;
			//}
			//else
			//{
			//	double deltax = Math.Abs(movingObj.x - moveToObj.x) * pathIncreament;
			//	double deltay = Math.Abs(movingObj.y - moveToObj.y) * pathIncreament;

			//	if (moveToObj.x > movingObj.x)
			//	{
			//		movingObj.x += deltax;
			//	}
			//	else
			//	{
			//		movingObj.x -= deltax;
			//	}

			//	if (moveToObj.y > movingObj.y)
			//	{
			//		movingObj.y += deltay;
			//	}
			//	else
			//	{
			//		movingObj.y -= deltay;
			//	}
			//}
		}
	}


	public class Solution
	{
		public int solution(string S)
		{
			MavableObj obj1 = new MavableObj() { x = 0, y = 0 };

			MavableObj obj2 = new MavableObj() { x = 2, y = 2 };

			Mover mover = new Mover();
			mover.Speed = 1;

			mover.MoveCloser(obj1, obj2);
			mover.MoveCloser(obj1, obj2);
			mover.MoveCloser(obj1, obj2);
			mover.MoveCloser(obj1, obj2);

			return 0;
		}
	}
}
