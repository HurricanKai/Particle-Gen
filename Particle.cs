using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Testing
{
	public class Particle
	{
		public double x, y, z;
		public Particle(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public Particle(Vector3d vec)
		{
			this.x = vec.X;
			this.y = vec.Y;
			this.z = vec.Z;
		}

		public Particle(Vector3 vec)
		{
			this.x = vec.X;
			this.y = vec.Y;
			this.z = vec.Z;
		}

		public Vector3d ToVector()
		{
			return new Vector3d(x, y, z);
		}

		public void MakeShort(int v)
		{
			string xs = x.ToString();
			if (xs.Length > v)
			xs.Remove(v);
			x = double.Parse(xs);
			string ys = y.ToString();
			if (ys.Length > v)
				ys.Remove(v);
			y = double.Parse(ys);
			string zs = z.ToString();
			if (zs.Length > v)
				zs.Remove(v);
			z = double.Parse(zs);
		}
	}
}
