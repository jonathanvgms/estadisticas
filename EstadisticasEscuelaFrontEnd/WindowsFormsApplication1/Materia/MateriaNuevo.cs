﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Materias
{
    public partial class frmMateriaNuevo : Form
    {
        EstadisticasEscuelaEntities context;

        public bool estado = true;

        private materia materiaModificada;

        internal materia MateriaModificada
        {
            get { return materiaModificada; }
            set { materiaModificada = value; }
        }
        public frmMateriaNuevo()
        {
            InitializeComponent();

            context = new EstadisticasEscuelaEntities();
        }

        private void btnMateriaNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriaBuscarLimpiar_Click(object sender, EventArgs e)
        {
            txtMateriaNuevoMateria.Clear();

            txtMateriaNuevoCodigo.Clear();

            lblMateriaNuevoCodigoVacio.Text = "";

            lblMateriaNuevaMateriaVacio.Text = "";

            lblMateriaNuevoError.Text = "";
        }

        private void btnMateriaNuevoAceptar_Click(object sender, EventArgs e)
        {
            bool error = true;

            materia mat;
            
            //falta verificar que el alumno existe en la base de datos

            if (error)
            {
                if (estado)
                {
                    if (context.materia.Any(x => x.Codigo == txtMateriaNuevoCodigo.Text))
                    {
                        lblMateriaNuevoError.Text = "LA MATERIA YA EXISTE";
                    }
                    else
                    {
                        //Materia.Add(new Materia(txtMateriaNuevoMateria.Text));
                        try
                        {
                            //int idmat = context.materia.Where(x => x.Nombre == txtMateriaNuevoMateria.Text).FirstOrDefault().Id;

                            context.materia.Add(new materia { Nombre = txtMateriaNuevoMateria.Text, Codigo = txtMateriaNuevoCodigo.Text });

                            context.SaveChanges();

                            lblMateriaNuevoError.Text = "MATERIA GUARDADA CON EXITO";
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
                else
                {
                    try
                    {

                        int idMater = Convert.ToInt32(materiaModificada.Id);

                        mat = context.materia.Where(x => x.Id == idMater).FirstOrDefault();

                        mat.Nombre = txtMateriaNuevoMateria.Text;

                        mat.Codigo = txtMateriaNuevoCodigo.Text;

                        context.SaveChanges();

                        lblMateriaNuevoError.Text = "MATERIA GUARDADA CON EXITO";
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
        }

        private void frmMateriaNuevo_Load(object sender, EventArgs e)
        {
            if(!estado)
            {
                txtMateriaNuevoMateria.Text = materiaModificada.Nombre;

                txtMateriaNuevoCodigo.Text = materiaModificada.Codigo;

                this.Text = "Modificar Materia";
            }
        }

        
    }
}
