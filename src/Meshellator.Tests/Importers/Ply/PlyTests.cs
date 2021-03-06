using NUnit.Framework;
using Nexus;

namespace Meshellator.Tests.Importers.Ply
{
	[TestFixture]
	public class PlyTests
	{
		[Test]
		public void CanImportBunny()
		{
			// Act.
			Scene scene = MeshellatorLoader.ImportFromFile(@"Models\Ply\Bunny.ply");

			// Assert.
			Assert.That(scene.Meshes, Has.Count.EqualTo(1));
			Assert.That(scene.Meshes[0].Positions, Has.Count.EqualTo(35947));
			Assert.That(scene.Meshes[0].Positions[0], Is.EqualTo(new Point3D(-0.0378297f, 0.12794f, 0.00447467f)));
			Assert.That(scene.Meshes[0].Normals, Has.Count.EqualTo(0));
			Assert.That(scene.Meshes[0].TextureCoordinates, Has.Count.EqualTo(0));
			Assert.That(scene.Meshes[0].Indices, Has.Count.EqualTo(69451 * 3));
			Assert.That(scene.Meshes[0].Indices[0], Is.EqualTo(20399));
			Assert.That(scene.Meshes[0].Indices[1], Is.EqualTo(21215));
			Assert.That(scene.Meshes[0].Indices[2], Is.EqualTo(21216));
		}

		[Test]
		public void CanImportWuson()
		{
			// Act.
			Scene scene = MeshellatorLoader.ImportFromFile(@"Models\Ply\Wuson.ply");

			// Assert.
			Assert.That(scene.Meshes, Has.Count.EqualTo(1));
			Assert.That(scene.Meshes[0].Positions, Has.Count.EqualTo(11184));
			Assert.That(scene.Meshes[0].Positions[0], Is.EqualTo(new Point3D(0.163313f, 0.540615f, -0.268688f)));
			Assert.That(scene.Meshes[0].Normals, Has.Count.EqualTo(11184));
			Assert.That(scene.Meshes[0].Normals[0], Is.EqualTo(new Vector3D(0.241919f, -0.961129f, 0.133063f)));
			Assert.That(scene.Meshes[0].TextureCoordinates, Has.Count.EqualTo(11184));
			Assert.That(scene.Meshes[0].TextureCoordinates[0], Is.EqualTo(new Point3D(0.681180f, 0.275678f, 0)));
			Assert.That(scene.Meshes[0].Indices, Has.Count.EqualTo(3732 * 3));
			Assert.That(scene.Meshes[0].Indices[0], Is.EqualTo(0));
			Assert.That(scene.Meshes[0].Indices[1], Is.EqualTo(1));
			Assert.That(scene.Meshes[0].Indices[2], Is.EqualTo(2));
		}
	}
}