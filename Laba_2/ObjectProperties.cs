using System;
using System.Numerics;

namespace Laba_2
{
    public class ObjectProperties
    {
        public Vector3 color = new Vector3(0, 5, 10);
        public Vector3 plainA;
        public Vector3 plainB;
        public float radius;
        public ObjectProperties()
        {
            plainA = new Vector3(0, 0, 0);
            plainB = new Vector3(0, 0, 10);
            radius = 5;
        }
        public ObjectProperties(float height, float radius)
        {
            plainA = new Vector3(0, 0, 0);
            plainB = new Vector3(0, height, 0);
            this.radius = radius;
        }
        public Vector4 cylIntersect(Vector3 rayOrigin, Vector3 rayDirection, Vector3 plainA, Vector3 plainB, float radius)
        {
            Vector3 ca = plainB - plainA;
            Vector3 oc = rayOrigin - plainA;
            float caca = Vector3.Dot(ca, ca);
            float card = Vector3.Dot(ca, rayDirection);
            float caoc = Vector3.Dot(ca, oc);
            float a = caca - card * card;
            float b = caca * Vector3.Dot(oc, rayDirection) - caoc * card;
            float c = caca * Vector3.Dot(oc, oc) - caoc * caoc - radius * radius * caca;
            float h = b * b - a * c;
            if (h < 0.0) return new Vector4(-1); //no intersection
            h = (float)Math.Sqrt(h);
            float t = (-b - h) / a;
            // body
            float y = caoc + t * card;
            if (y > 0.0 && y <= caca) return new Vector4((oc + t * rayDirection - ca * y / caca) / radius, t);
            // caps
            t = (float)(((y < 0.0) ? 0.0 : caca) - caoc) / card;
            if (Math.Abs(b + a * t) < h) return new Vector4(ca * Math.Sign(y) / caca, t);
            return new Vector4(-1); //no intersection
        }
    }
}
