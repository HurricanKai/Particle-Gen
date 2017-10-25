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

		public Vector3d ToVector()
		{
			return new Vector3d(x, y, z);
		}

		public void MakeShort(int v)
		{
			string xs = x.ToString().Remove(v);
			x = double.Parse(xs);
			string ys = y.ToString().Remove(v);
			y = double.Parse(ys);
			string zs = z.ToString().Remove(v);
			z = double.Parse(zs);
		}
	}
}
