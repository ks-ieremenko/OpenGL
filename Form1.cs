using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;

namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Glut.glutInit(); // инициализация Glut 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH); // устанвока начального режима отображения
        }
        private void Lighting(float[] mtClr, float[] lghtClr)
        {
            float[] light_position = { 0.5f, 0.5f, 0.5f, 1.0f }; // Координаты источника света
            Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL); // Заливка
            Gl.glShadeModel(Gl.GL_SMOOTH); // Вывод с интерполяцией цветов
            Gl.glEnable(Gl.GL_LIGHTING); // Включаю освещенность
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lghtClr); // Рассеивание
            Gl.glEnable(Gl.GL_LIGHT0); // Включаем в уравнение освещенности источник GL_LIGHT0
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
        }
        public void RotationGlut() // процедура поворота для 3D фигур
        {
            Gl.glTranslated(tbTrX.Value, tbTrY.Value, tbTrZ.Value); // перенос по Х,Y,Z
            if (chBRotX.Checked) // для автоматического вращения по Х
            {
                if (tbRotX.Value + 1 > 360)
                    tbRotX.Value = -360;
                Gl.glRotated(tbRotX.Value += 1, 1.0f, 0.0f, 0.0f); 
            }
            else
                Gl.glRotated(tbRotX.Value, 1.0f, 0.0f, 0.0f); // для вращения по трекбару по Х
            if (chBRotY.Checked)// для автоматического вращения по Y
            {
                if (tbRotY.Value + 1 > 360)
                    tbRotY.Value = -360;
                Gl.glRotated(tbRotY.Value += 1, 0.0f, 1.0f, 0.0f);
            }
            else
                Gl.glRotated(tbRotY.Value, 0.0f, 1.0f, 0.0f); // для вращения по трекбару по Y
            if (chBRotZ.Checked)// для вращения по трекбару по Z
            {
                if (tbRotZ.Value + 1 > 360)
                    tbRotZ.Value = -360;
                Gl.glRotated(tbRotZ.Value += 1, 0.0f, 0.0f, 1.0f);
            }
            else
                Gl.glRotated(tbRotZ.Value, 0.0f, 0.0f, 1.0f); // для вращения по трекбару по Z

            XRtText.Text = tbRotX.Value.ToString(); //отображение градусов и единиц переноса на label
            YRtText.Text = tbRotY.Value.ToString();
            ZRtText.Text = tbRotZ.Value.ToString();
            XTrText.Text = tbTrX.Value.ToString();
            YTrText.Text = tbTrY.Value.ToString();
            ZTrText.Text = tbTrZ.Value.ToString();
        }
        private void DrawCube()
        { 
            //рисование куба с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.7f, 0.6f, 0.8f);

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -5f); // перенос по Z
            RotationGlut();
 
            if (Wire.Checked)
                Glut.glutWireCube(1);// сеточный режим
            else
                Glut.glutSolidCube(1);//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
        }
        private void DrawPyramid(OpenGL glPyramid)
        {
            // выключение освещения
            glPyramid.Disable(OpenGL.GL_LIGHT0);
            glPyramid.Disable(OpenGL.GL_LIGHTING);

            glPyramid.Translate(0.0f, 0.0f, -5.0f); // перенос по Z

            Rotation(glPyramid);//вращение пирамиды

            // Рисуем треугольники - грани пирамиды
            glPyramid.Begin(OpenGL.GL_TRIANGLES);
            // Передняя грань
            glPyramid.Color(1.0f, 0.0f, 1.0f);
            glPyramid.Vertex(0.0f, 1.0f, 0.0f); // вершина
            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, 1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, 1.0f);
            // Правая грань
            glPyramid.Color(1.0f, 0.0f, 1.0f);
            glPyramid.Vertex(0.0f, 1.0f, 0.0f);// вершина
            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, -1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, 1.0f);
            // Задняя грань
            glPyramid.Color(1.0f, 0.0f, 1.0f);
            glPyramid.Vertex(0.0f, 1.0f, 0.0f);// вершина
            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, -1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, -1.0f);
            // Левая грань
            glPyramid.Color(1.0f, 0.0f, 1.0f);
            glPyramid.Vertex(0.0f, 1.0f, 0.0f);// вершина
            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, 1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, -1.0f);
            glPyramid.End();
            // Рисуем квадрат - дно пирамиды
            glPyramid.Begin(OpenGL.GL_QUADS);//четыерхугольник

            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, -1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(1.0f, -1.0f, 1.0f);
            glPyramid.Color(0.0f, 1.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, 1.0f);
            glPyramid.Color(0.0f, 0.0f, 1.0f);
            glPyramid.Vertex(-1.0f, -1.0f, -1.0f);

            glPyramid.End(); // конец отрисовки
            glPyramid.Flush();// довыполнение предыдущих команд
        }
        private void DrawTeapot()
        {
            //рисование чайника с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(1f, 0.6f, 0.6f); //цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -5f); // перенос по Z

            RotationGlut();// поворот

            // рисуем чайник с помощью библиотеки FreeGLUT 
            if (Wire.Checked)
                Glut.glutWireTeapot(1);// сеточный режим
            else
                Glut.glutSolidTeapot(1);//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд
        }
        private void DrawTorus()
        {
            //рисование тора с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.8f, 0.4f, 0.4f);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -5);// перенос по Z

            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireTorus(0.3, 0.65, 16, 16);// сеточный режим
            else
                Glut.glutSolidTorus(0.3, 0.65, 16, 16);//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд
        }
        private void DrawCone()
        {
            //рисование конуса с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.6f, 1, 0.6f);//цвет фигуры без освещения
            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, -0.3f, -2); // перенос по Y,Z
            RotationGlut();// поворот
            if (Wire.Checked)
                Glut.glutWireCone(0.2, 0.75, 16, 8);// сеточный режим
            else
                Glut.glutSolidCone(0.2, 0.75, 16, 8);//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        private void DrawCylinder()
        {
            //рисование цилиндра с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(1f, 0.7f, 0.2f);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, -0.3f, -2);// перенос по Y,Z
            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireCylinder(0.2, 0.75, 16, 16);// сеточный режим
            else
                Glut.glutSolidCylinder(0.2, 0.75, 16, 16);//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        private void DrawIcosahedron()
        {
            //рисование икосаэдра с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.6f, 1f, 0.8f);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -4f);// перенос по Z

            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireIcosahedron();// сеточный режим
            else
                Glut.glutSolidIcosahedron();//режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        private void DrawDodecahedron()
        {
            //рисование додекаэдра с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.8f, 0.6f, 1f);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -6);// перенос по Z

            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireDodecahedron();// сеточный режим
            else
                Glut.glutSolidDodecahedron();//режим с заливкой

            Gl.glPopMatrix();//возвращение к старым координатам
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        private void DrawOctahedron()
        {
            //рисование октаэдра с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.92f, 0.89f, 0.39f);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -3);// перенос по Z

            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireOctahedron();// сеточный режим
            else
                Glut.glutSolidOctahedron();//режим с заливкой

            Gl.glPopMatrix();//возвращение к старым координатам
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        private void DrawSphere()
        {
            //рисование сферы с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.8f, 1, 1);//цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -7);// перенос по Z

            RotationGlut();// поворот

            if (Wire.Checked)
                Glut.glutWireSphere(2, 32, 32);// сеточный режим
            else
                Glut.glutSolidSphere(2, 32, 32);//режим с заливкой

            Gl.glPopMatrix();//возвращение к старым координатам
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд
        }
        private void DrawTetrahedron()
        {
            //рисование тетраэдра с помощью библиотеки FreeGlut
            Gl.glDisable(Gl.GL_BLEND);
            Gl.glColor3f(0.9f, 0.7f, 0.7f); //цвет фигуры без освещения

            Gl.glPushMatrix();// сохраняет текущие координаты
            Gl.glTranslated(0, 0, -3);// перенос по Z

            RotationGlut(); // поворот

            if (Wire.Checked)
                Glut.glutWireTetrahedron(); // сеточный режим
            else
                Glut.glutSolidTetrahedron(); //режим с заливкой

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // пересчитываем освещение
            Gl.glFlush(); // довыполнение предыдущих команд

        }
        public void Rotation(OpenGL gl)
        {
            gl.Translate(tbTrX.Value, tbTrY.Value, tbTrZ.Value); //перенос по X,Y,Z
            if (chBRotX.Checked) // автоматичское вращение по Х
            {
                if (tbRotX.Value + 4 > 360)
                    tbRotX.Value = -360;
                gl.Rotate(tbRotX.Value += 4, 1.0f, 0.0f, 0.0f);
            }
            else
                gl.Rotate(tbRotX.Value, 1.0f, 0.0f, 0.0f); //  вращение по трекбару по Х
            if (chBRotY.Checked)// автоматичское вращение по Y
            {
                if (tbRotY.Value + 4 > 360)
                    tbRotY.Value = -360;
                gl.Rotate(tbRotY.Value += 4, 0.0f, 1.0f, 0.0f);
            }
            else
                gl.Rotate(tbRotY.Value, 0.0f, 1.0f, 0.0f);//  вращение по трекбару по Y
            if (chBRotZ.Checked)// автоматичское вращение по Z
            {
                if (tbRotZ.Value + 4 > 360)
                    tbRotZ.Value = -360;
                gl.Rotate(tbRotZ.Value += 4, 0.0f, 0.0f, 1.0f);
            }
            else
                gl.Rotate(tbRotZ.Value, 0.0f, 0.0f, 1.0f);//  вращение по трекбару по Z
        }
        public void DrawA()
        {
            //рисование буквы А
            Gl.glDisable(Gl.GL_LIGHT0);// выключение освещения
            Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);// Очистка экрана и буфера глубин
            Gl.glLoadIdentity();
            Gl.glTranslated(-0.6f, -0.6f, -1.5f);//перенос по Z

            Gl.glBegin(Gl.GL_LINE_LOOP); // рисование линий

            Gl.glColor3f(1.0f, 0.0f, 0.0f); //цвет
            Gl.glVertex2f(8.2f / 27f, 7 / 27f);
            Gl.glVertex2f(15 / 27f, 27f / 27f);
            Gl.glVertex2f(17f / 27f, 27f / 27f);
            Gl.glVertex2f(23.8f / 27f, 7 / 27f);
            Gl.glVertex2f(22.1f / 27f, 7 / 27f);
            Gl.glVertex2f(19.6f / 27f, 14.5f / 27f);
            Gl.glVertex2f(12.4f / 27f, 14.5f / 27f);
            Gl.glVertex2f(10f / 27f, 7 / 27f);
            Gl.glEnd(); // конец отрисовки

            Gl.glBegin(Gl.GL_LINE_LOOP); // внутрення часть буквы А
            Gl.glVertex2f(13f / 27f, 16 / 27f);
            Gl.glVertex2f(16f / 27f, 25 / 27f);
            Gl.glVertex2f(19f / 27f, 16 / 27f);

            Gl.glEnd();// конец отрисовки
            Gl.glFlush();// довыполнение предыдущих команд
        }
        public void DrawK()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glTranslated(0f, 0f, -4f);

            Gl.glBegin(Gl.GL_LINE_LOOP);// рисование линий

            Gl.glColor3f(0.0f, 0.0f, 1.0f); //цвет
            Gl.glVertex2f(-2.5f / 7f, -4f / 7f);
            Gl.glVertex2f(-2.5f / 7f, 7f / 7f);
            Gl.glVertex2f(-1f / 7f, 7f / 7f);
            Gl.glVertex2f(-1f / 7f, 2f / 7f);
            Gl.glVertex2f(2.5f / 7f, 7f / 7f);
            Gl.glVertex2f(4.2f / 7f, 7f / 7f);
            Gl.glVertex2f(0.4f / 7f, 1.5f / 7f);
            Gl.glVertex2f(4.2f / 7f, -4f / 7f);
            Gl.glVertex2f(2.5f / 7f, -4f / 7f);
            Gl.glVertex2f(-1f / 7f, 1f / 7f);
            Gl.glVertex2f(-1f / 7f, -4f / 7f);

            Gl.glEnd();// конец отрисовки
            Gl.glFlush();// довыполнение предыдущих команд
        }
        public void DrawM()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslated(0f, 0f, -5f);

            Gl.glBegin(Gl.GL_LINE_LOOP);// рисование линий
            Gl.glColor3f(0.0f, 1.0f, 0.0f); //цвет
            Gl.glVertex2f(-3.5f / 6f, -4f / 6f);
            Gl.glVertex2f(-3.5f / 6f, 5.5f / 6f);
            Gl.glVertex2f(-2f / 6f, 5.5f / 6f);
            Gl.glVertex2f(1f / 6f, 1.5f / 6f);
            Gl.glVertex2f(4f / 6f, 5.5f / 6f);
            Gl.glVertex2f(5.5f / 6f, 5.5f / 6f);
            Gl.glVertex2f(5.5f / 6f, -4f / 6f);
            Gl.glVertex2f(4f / 6f, -4f / 6f);
            Gl.glVertex2f(4f / 6f, 3f / 6f);
            Gl.glVertex2f(1f / 6f, -1f / 6f);
            Gl.glVertex2f(-2f / 6f, 3f / 6f);
            Gl.glVertex2f(-2f / 6f, -4f / 6f);

            Gl.glEnd();// конец отрисовки
            Gl.glFlush();// довыполнение предыдущих команд
        }
        public void DrawSquare()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslated(0f, 0f, -5f);

            Gl.glBegin(Gl.GL_QUADS);//четыерхугольник

            Gl.glColor3f(1.0f, 0.0f, 1.0f);
            Gl.glVertex2d(1f, -0.5f);
            Gl.glVertex2d(-0.5f, -0.5f);

            Gl.glColor3f(0.0f, 1.0f, 1.0f);
            Gl.glVertex2d(-0.5f, 1f);
            Gl.glVertex2d(1f, 1f);

            Gl.glEnd();// конец отрисовки
            Gl.glFlush();// довыполнение предыдущих команд
        }
        public void DrawTriangle()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslated(0f, 0f, -5f);

            Gl.glBegin(Gl.GL_TRIANGLES); //рисуем треугольник

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex2d(-0.5f, -0.5f);

            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glVertex2d(-0.5f, 1f);

            Gl.glColor3f(0.0f, 1.0f, 1.0f);
            Gl.glVertex2d(1f, -0.5f);

            Gl.glEnd();// конец отрисовки

            Gl.glBegin(Gl.GL_LINE_LOOP); // рисуем контур треугольника черной линией

            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glVertex2d(-0.5f, -0.5f);
            Gl.glVertex2d(-0.5f, 1f);
            Gl.glVertex2d(1f, -0.5f);

            Gl.glEnd();// конец отрисовки
            Gl.glFlush();// довыполнение предыдущих команд
        }
        private void DrawAxis()
        {
            //выключение освещения
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT); // очистка буфера
            Gl.glLoadIdentity();
            Gl.glPushMatrix(); // сохраняет текущие координаты
            Gl.glTranslated(0f, 0f, -6f); // перенос по Z
            // сглаживание линий
            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            RotationGlut();// вращение

            Gl.glRotatef(0, 1, 0, 0);
            Gl.glRotatef(0, 0, 1, 0);
            Gl.glRotatef(30, 0, 0, 1); // поворот на 30 градусов по Z

            Gl.glBegin(Gl.GL_LINES); //рисуем линии

            Gl.glColor3f(0.67f, 0.65f, 1f); //цвет оси Х
            Gl.glVertex3f(10, 0, 0);
            Gl.glVertex3f(-10, 0, 0);// Ось X

            Gl.glColor3f(0.68f, 0.95f, 0.72f);//цвет оси Y
            Gl.glVertex3f(0, 10, 0);
            Gl.glVertex3f(0, -10, 0);//Ось Y

            Gl.glColor3f(0.84f, 0.58f, 0.58f);//цвет оси Z
            Gl.glVertex3f(0, 0, -10);
            Gl.glVertex3f(0, 0, 0);//Ось Z

            Gl.glColor3f(0.84f, 0.58f, 0.58f);//цвет оси Z
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(0, 0, 10);//Ось Z
            Gl.glEnd(); // конец отрисовки

            Gl.glPopMatrix();//возвращение к старым координатам
            Gl.glFlush();// довыполнение предыдущих команд
            //включение освещения
            if (!Light.Checked) // если не стоит галочка - выключение освещения
            {
                Gl.glDisable(Gl.GL_LIGHT0);
                Gl.glDisable(Gl.GL_LIGHTING);
            }
            else
            {
                Gl.glEnable(Gl.GL_LIGHTING);
                Gl.glEnable(Gl.GL_LIGHT0);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbRotX.Value = 0; tbRotY.Value = 0;
            tbRotZ.Value = 0; chBRotX.Checked = false;
            chBRotY.Checked = false; chBRotZ.Checked = false;
            tbTrX.Value = 0; tbTrY.Value = 0; tbTrZ.Value = 0;
            if (tabControl1.SelectedTab.Text == "3D")
                if (comboBox1.SelectedItem.Equals("Конус") || comboBox1.SelectedItem.Equals("Цилиндр"))
                {
                    Gl.glTranslated(0f, -0.3f, 0f);
                    tbRotX.Value = -90;
                }
        }
        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = openGLControl1.OpenGL;

            // Очистка экрана и буфера глубин
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);

            if (tabControl1.SelectedTab.Text == "2D")
            {
                comboBox1.SelectedIndex = -1;
                // сглаживание линий
                Gl.glEnable(Gl.GL_LINE_SMOOTH);
                Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
                Gl.glEnable(Gl.GL_POINT_SMOOTH);
                Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
                Gl.glEnable(Gl.GL_BLEND);
                Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
                Gl.glClearColor(1, 1, 1, 1);
            }
            else
            {
                comboBox2.SelectedIndex = -1;
                Gl.glDisable(Gl.GL_BLEND);
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                Gl.glLoadIdentity();
                Gl.glClearColor(0, 0, 0, 0);
            }

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();// считывает текущую матрицу
            Gl.glPushMatrix();// сохраняет текущие координаты
            if (Axes.Checked)
                DrawAxis(); // отображение осей

            float[] main = new float[4]; //цвет фигуры
            float[] light = new float[4]; // цвет освещения

            switch (comboBox1.Text)
            {
                case "Куб":
                    DrawCube();
                    main = new float[4] { 0.7f, 0.6f, 0.8f, 0 };
                    light = new float[4] { 0f, 0.8f, 0.4f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Пирамида":
                    DrawPyramid(gl);
                    break;
                case "Чайник":
                    DrawTeapot();
                    main = new float[4] { 1f, 0.6f, 0.6f, 0 };
                    light = new float[4] { 0.6f, 0.2f, 1, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Сфера":
                    DrawSphere();
                    main = new float[4] { 0.8f, 1, 1, 0 };
                    light = new float[4] { 0f, 0, 0.8f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Конус":
                    DrawCone();
                    main = new float[4] { 0.6f, 1, 0.6f, 0 };
                    light = new float[4] { 0.3f, 0.7f, 0.3f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Цилиндр":
                    DrawCylinder();
                    main = new float[4] { 1f, 0.7f, 0.2f, 0 };
                    light = new float[4] { 0.8f, 0f, 0, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Тор":
                    DrawTorus();
                    main = new float[4] { 0.8f, 0.4f, 0.4f, 0f };
                    light = new float[4] { 0.55f, 0.08f, 0.08f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Икосаэдр":
                    DrawIcosahedron();
                    main = new float[4] { 0.6f, 1f, 0.8f, 0 };
                    light = new float[4] { 0f, 0.8f, 0.4f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Октаэдр":
                    DrawOctahedron();
                    main = new float[4] { 0.92f, 0.89f, 0.39f, 0f };
                    light = new float[4] { 1f, 1f, 0f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Тетраэдр":
                    DrawTetrahedron();
                    main = new float[4] { 0.9f, 0.7f, 0.7f, 0 };
                    light = new float[4] { 0.5f, 0.09f, 0.72f, 0 };
                    openGLControl1.Invalidate();
                    break;
                case "Додeкаэдр":
                    DrawDodecahedron();
                    main = new float[4] { 0.8f, 0.6f, 1f, 0 };
                    light = new float[4] { 0.3f, 0, 0.6f, 0 };
                    openGLControl1.Invalidate();
                    break;
            }
            if (Light.Checked)
                Lighting(main, light); //свет
            switch (comboBox2.Text) //2D
            {
                case "Буква К":
                    DrawK();
                    break;
                case "Буква А":
                    DrawA();
                    break;
                case "Буква М":
                    DrawM();
                    break;
                case "Квадрат":
                    DrawSquare();
                    break;
                case "Треугольник":
                    DrawTriangle();
                    break;
            }
        }
    }
}