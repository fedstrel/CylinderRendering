using System;
using System.Numerics;

namespace Laba_2
{
    public class Lighting
    {
        public Vector3 direction;
        public Vector3 color;
        public float intensity;
        public float ambientStrength = 0.1f;
        public float specularStrength = 0.8f;
        public int specPower;

        public Lighting(Vector3 direction, Vector3 color, float intensity, int specPower)
        {
            this.direction = Vector3.Normalize(direction);
            this.color = color;
            this.intensity = intensity;
            this.specPower = specPower;
        }

        public Vector3 getAmbient()
        {
            return ambientStrength * color;
        }

        public Vector3 getDiffuse(Vector3 norm)
        {
            return 0.125f * Math.Max(Vector3.Dot(Vector3.Normalize(norm), -direction), 0f) * color;
        }

        public Vector3 getSpecular(Vector3 rayDirection, Vector3 norm)
        {
            Vector3 reflectDir = Vector3.Reflect(-direction, norm);
            return specularStrength * (float)Math.Pow(Math.Max(Vector3.Dot(rayDirection, reflectDir), 0f), specPower) * color;
        }
    }
}
