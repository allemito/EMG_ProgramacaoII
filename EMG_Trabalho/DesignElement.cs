using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
   abstract class DesignElement
    {
        private float x, y, largura, altura;
        Pen pen;
        Graphics g;

        public Graphics G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }
        public Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }
        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        public float Largura
        {
            get
            {
                return largura;
            }

            set
            {
                largura = value;
            }
        }
        public float Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public DesignElement(float x, float y, float largura, float altura, Pen pen, Graphics g)
        {
            this.X = x;
            this.Y = y;
            this.Largura = largura;
            this.Altura = altura;
            this.Pen = pen;
            this.G = g;
        }

        public DesignElement(Pen pen, Graphics g)
        {

        }

        abstract public void draw();
    }
}
