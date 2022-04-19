using System.Numerics;

namespace Laba_2
{
    public class ProjectionParams
    {
        public Vector3 rayDirection { get; set; }
        public Vector3 plainVectorX { get; set; }
        public Vector3 plainVectorY { get; set; }

        public ProjectionParams(Vector3 rayDirection) {
            this.rayDirection = rayDirection;
            plainVectorX = Vector3.Normalize(new Vector3(-rayDirection.Z, 0, rayDirection.X));
            plainVectorY = Vector3.Normalize(Vector3.Cross(rayDirection, plainVectorX));
        }
    }
}
