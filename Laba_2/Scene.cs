using System.Drawing;
using System.Numerics;


namespace Laba_2
{
    class Scene
    {
        ProjectionParams projectionParams;
        int size;
        Lighting lighting;
        public Scene(Vector3 rayDirection, Vector3 lightDirection, Vector3 lightColor, float intensity, int specPower, int size)
        {
            projectionParams = new ProjectionParams(rayDirection);
            this.size = size;
            lighting = new Lighting(lightDirection, lightColor, intensity, specPower);
        }
        public Bitmap DrawPicture(int imgHeight, int imgWidth, float height, float radius)
        {
            ObjectProperties props = new ObjectProperties(height, radius);
            Bitmap bmp = new Bitmap(imgWidth, imgHeight);
            BitmapWrapper wrapper = new BitmapWrapper(bmp);
            Vector3 corner = (-0.5f) * (projectionParams.plainVectorX * size + projectionParams.plainVectorY * size);
            Vector3 norm;
            Vector4 res;
            projectionParams.plainVectorX = projectionParams.plainVectorX * size / bmp.Width;
            projectionParams.plainVectorY = projectionParams.plainVectorY * size / bmp.Height;           
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    res = props.cylIntersect(corner + j * projectionParams.plainVectorX + i * projectionParams.plainVectorY,
                                            projectionParams.rayDirection,
                                            props.plainA,
                                            props.plainB,
                                            props.radius);
                    if (res.X != -1 || res.Y != -1 || res.Z != -1 || res.W != -1)
                    {
                        norm = new Vector3(res.X, res.Y, res.Z);
                        wrapper.setPixel(j, i, Vector3.Clamp((lighting.getAmbient() + 
                                                                lighting.getDiffuse(norm) * props.color + lighting.getSpecular(projectionParams.rayDirection, norm)),
                                                              new Vector3(0),
                                                              new Vector3(255)));
                    }
                    else
                        wrapper.setPixel(j, i, new Vector3(0));
                }
            }
            return wrapper.getBitmap(bmp);
        }
    }
}
