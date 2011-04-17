package Vista;

import javax.swing.JFrame;

public class frmTecnico extends javax.swing.JDialog {

    public frmTecnico(JFrame padre, boolean modal) {
        super(padre, modal);
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTabbedPane1 = new javax.swing.JTabbedPane();
        pnlBuscar = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        dgvTecnicos = new javax.swing.JTable();
        pnlCriterios = new javax.swing.JPanel();
        lblPaterno = new javax.swing.JLabel();
        txtPaterno = new javax.swing.JTextField();
        lblMaterno = new javax.swing.JLabel();
        txtMaterno = new javax.swing.JTextField();
        lblNombres = new javax.swing.JLabel();
        txtNombres = new javax.swing.JTextField();
        lblEstado = new javax.swing.JLabel();
        cboEstado = new javax.swing.JComboBox();
        btnVer = new javax.swing.JButton();
        btnNuevo = new javax.swing.JButton();
        btnModificar = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        lblDetalle = new javax.swing.JPanel();
        lblFechaNacimiento = new javax.swing.JLabel();
        txtDNI = new javax.swing.JTextField();
        lblDNI = new javax.swing.JLabel();
        cboSexo = new javax.swing.JComboBox();
        lblEstadoCivil = new javax.swing.JLabel();
        calFechaNacimiento = new de.wannawork.jcalendar.JCalendarComboBox();
        lblSexo = new javax.swing.JLabel();
        txtDomicilio = new javax.swing.JTextField();
        lblDepartamento = new javax.swing.JLabel();
        cboEstadoCivil = new javax.swing.JComboBox();
        lblDomicilio = new javax.swing.JLabel();
        txtTelefono = new javax.swing.JTextField();
        lblTelefono = new javax.swing.JLabel();
        cboDistrito = new javax.swing.JComboBox();
        lblDistrito = new javax.swing.JLabel();
        cboProvincia = new javax.swing.JComboBox();
        lblPaternoDetalle = new javax.swing.JLabel();
        txtPaternoDetalle = new javax.swing.JTextField();
        lblMaternoDetalle = new javax.swing.JLabel();
        txtMaternoDetalle = new javax.swing.JTextField();
        cboDepartamento = new javax.swing.JComboBox();
        lblNombresDetalle = new javax.swing.JLabel();
        lblProvincia = new javax.swing.JLabel();
        txtNombresDetalle = new javax.swing.JTextField();
        lblEmail = new javax.swing.JLabel();
        txtEmail = new javax.swing.JTextField();
        lblEstadoDetalle = new javax.swing.JLabel();
        cboEstadoDetalle = new javax.swing.JComboBox();
        btnCancelar = new javax.swing.JButton();
        btnGuardar = new javax.swing.JButton();
        lblUsuario = new javax.swing.JLabel();
        txtUsuario = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("Técnico(a)");
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });

        dgvTecnicos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null},
                {null, null, null},
                {null, null, null},
                {null, null, null}
            },
            new String [] {
                "Ap. Paterno", "Ap. Materno", "Nombres"
            }
        ));
        jScrollPane1.setViewportView(dgvTecnicos);

        pnlCriterios.setBorder(javax.swing.BorderFactory.createTitledBorder("Criterios de Búsqueda"));

        lblPaterno.setText("Apellido Paterno:");

        lblMaterno.setText("Apellido Materno:");

        lblNombres.setText("Nombres:");

        lblEstado.setText("Estado:");

        cboEstado.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "ACTIVO", "INACTIVO", "TODOS" }));

        javax.swing.GroupLayout pnlCriteriosLayout = new javax.swing.GroupLayout(pnlCriterios);
        pnlCriterios.setLayout(pnlCriteriosLayout);
        pnlCriteriosLayout.setHorizontalGroup(
            pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlCriteriosLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(txtNombres, javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(lblPaterno, javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(txtPaterno, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 170, Short.MAX_VALUE))
                    .addComponent(lblNombres))
                .addGap(18, 18, 18)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(lblEstado)
                    .addComponent(txtMaterno, javax.swing.GroupLayout.DEFAULT_SIZE, 170, Short.MAX_VALUE)
                    .addComponent(lblMaterno)
                    .addComponent(cboEstado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(22, Short.MAX_VALUE))
        );
        pnlCriteriosLayout.setVerticalGroup(
            pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlCriteriosLayout.createSequentialGroup()
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblPaterno)
                    .addComponent(lblMaterno))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtPaterno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtMaterno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblNombres)
                    .addComponent(lblEstado))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtNombres, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboEstado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(64, Short.MAX_VALUE))
        );

        btnVer.setText("Ver");

        btnNuevo.setText("Nuevo");

        btnModificar.setText("Modificar");

        btnEliminar.setText("Eliminar");

        btnSalir.setText("Salir");

        javax.swing.GroupLayout pnlBuscarLayout = new javax.swing.GroupLayout(pnlBuscar);
        pnlBuscar.setLayout(pnlBuscarLayout);
        pnlBuscarLayout.setHorizontalGroup(
            pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlBuscarLayout.createSequentialGroup()
                .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlBuscarLayout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 399, Short.MAX_VALUE)
                            .addGroup(pnlBuscarLayout.createSequentialGroup()
                                .addComponent(btnVer, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnNuevo, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnSalir, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlBuscarLayout.createSequentialGroup()
                        .addGap(7, 7, 7)
                        .addComponent(pnlCriterios, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addContainerGap())
        );
        pnlBuscarLayout.setVerticalGroup(
            pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlBuscarLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(pnlCriterios, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 161, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnVer)
                    .addComponent(btnNuevo)
                    .addComponent(btnModificar)
                    .addComponent(btnEliminar)
                    .addComponent(btnSalir))
                .addContainerGap(17, Short.MAX_VALUE))
        );

        jTabbedPane1.addTab("Buscar", pnlBuscar);

        lblFechaNacimiento.setText("Fecha Nacimiento:");

        lblDNI.setText("DNI:");

        cboSexo.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "M", "F" }));

        lblEstadoCivil.setText("Estado Civil:");

        lblSexo.setText("Sexo:");

        txtDomicilio.setToolTipText("");

        lblDepartamento.setText("Departamento:");

        cboEstadoCivil.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "SOLTERO", "CASADO", "VIUDO", "DIVORCIADO", "OTRO" }));

        lblDomicilio.setText("Domicilio:");

        lblTelefono.setText("Teléfono:");

        lblDistrito.setText("Distrito:");

        lblPaternoDetalle.setText("Apellido Paterno:");

        lblMaternoDetalle.setText("Apellido Materno:");

        lblNombresDetalle.setText("Nombres:");

        lblProvincia.setText("Provincia:");

        lblEmail.setText("Email:");

        lblEstadoDetalle.setText("Estado:");

        cboEstadoDetalle.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "ACTIVO", "INACTIVO" }));

        btnCancelar.setText("Cancelar");
        btnCancelar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        btnGuardar.setText("Guardar");
        btnGuardar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        lblUsuario.setText("Nombre de Usuario:");

        javax.swing.GroupLayout lblDetalleLayout = new javax.swing.GroupLayout(lblDetalle);
        lblDetalle.setLayout(lblDetalleLayout);
        lblDetalleLayout.setHorizontalGroup(
            lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(lblDetalleLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblNombresDetalle)
                    .addGroup(lblDetalleLayout.createSequentialGroup()
                        .addComponent(lblPaternoDetalle)
                        .addGap(118, 118, 118)
                        .addComponent(lblMaternoDetalle))
                    .addGroup(lblDetalleLayout.createSequentialGroup()
                        .addComponent(txtPaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtMaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(lblDomicilio)
                    .addGroup(lblDetalleLayout.createSequentialGroup()
                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(txtNombresDetalle, javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, lblDetalleLayout.createSequentialGroup()
                                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(lblDetalleLayout.createSequentialGroup()
                                        .addComponent(lblDNI)
                                        .addGap(58, 58, 58)
                                        .addComponent(lblFechaNacimiento))
                                    .addGroup(lblDetalleLayout.createSequentialGroup()
                                        .addComponent(txtDNI, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(10, 10, 10)
                                        .addComponent(calFechaNacimiento, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(lblDetalleLayout.createSequentialGroup()
                                        .addGap(19, 19, 19)
                                        .addComponent(lblSexo))
                                    .addGroup(lblDetalleLayout.createSequentialGroup()
                                        .addGap(18, 18, 18)
                                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                        .addGap(18, 18, 18)
                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(cboEstadoCivil, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblEstadoCivil))
                        .addGap(15, 15, 15))
                    .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addGroup(lblDetalleLayout.createSequentialGroup()
                            .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(btnGuardar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addComponent(txtDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, 380, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, lblDetalleLayout.createSequentialGroup()
                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(lblDetalleLayout.createSequentialGroup()
                                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblUsuario)
                                    .addGroup(lblDetalleLayout.createSequentialGroup()
                                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                            .addComponent(txtUsuario, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(txtTelefono, javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(cboDepartamento, javax.swing.GroupLayout.Alignment.LEADING, 0, 120, Short.MAX_VALUE)
                                            .addComponent(lblTelefono, javax.swing.GroupLayout.Alignment.LEADING))
                                        .addGap(10, 10, 10)
                                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(cboProvincia, 0, 135, Short.MAX_VALUE)
                                            .addComponent(lblEmail)
                                            .addComponent(txtEmail, javax.swing.GroupLayout.DEFAULT_SIZE, 135, Short.MAX_VALUE))))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED))
                            .addGroup(lblDetalleLayout.createSequentialGroup()
                                .addComponent(lblDepartamento)
                                .addGap(57, 57, 57)
                                .addComponent(lblProvincia)
                                .addGap(94, 94, 94)))
                        .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblDistrito)
                            .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(lblEstadoDetalle)
                                .addComponent(cboEstadoDetalle, 0, 109, Short.MAX_VALUE)
                                .addComponent(cboDistrito, 0, 109, Short.MAX_VALUE)))
                        .addGap(11, 11, 11)))
                .addGap(15, 15, 15))
        );
        lblDetalleLayout.setVerticalGroup(
            lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(lblDetalleLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblPaternoDetalle)
                    .addComponent(lblMaternoDetalle))
                .addGap(1, 1, 1)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtPaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtMaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(lblNombresDetalle)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtNombresDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDNI)
                    .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(lblFechaNacimiento)
                        .addComponent(lblSexo)
                        .addComponent(lblEstadoCivil)))
                .addGap(6, 6, 6)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtDNI, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(cboEstadoCivil, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(calFechaNacimiento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(lblDomicilio)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(10, 10, 10)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDepartamento)
                    .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(lblProvincia)
                        .addComponent(lblDistrito)))
                .addGap(6, 6, 6)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cboProvincia, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboDepartamento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboDistrito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblTelefono)
                    .addComponent(lblEmail))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblEstadoDetalle)
                    .addComponent(lblUsuario))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cboEstadoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtUsuario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(lblDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnGuardar, javax.swing.GroupLayout.DEFAULT_SIZE, 55, Short.MAX_VALUE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.DEFAULT_SIZE, 55, Short.MAX_VALUE))
                .addContainerGap())
        );

        jTabbedPane1.addTab("Detalle", lblDetalle);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 421, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 451, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        this.dispose();
    }//GEN-LAST:event_formWindowClosing

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JButton btnSalir;
    private javax.swing.JButton btnVer;
    private de.wannawork.jcalendar.JCalendarComboBox calFechaNacimiento;
    private javax.swing.JComboBox cboDepartamento;
    private javax.swing.JComboBox cboDistrito;
    private javax.swing.JComboBox cboEstado;
    private javax.swing.JComboBox cboEstadoCivil;
    private javax.swing.JComboBox cboEstadoDetalle;
    private javax.swing.JComboBox cboProvincia;
    private javax.swing.JComboBox cboSexo;
    private javax.swing.JTable dgvTecnicos;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JLabel lblDNI;
    private javax.swing.JLabel lblDepartamento;
    private javax.swing.JPanel lblDetalle;
    private javax.swing.JLabel lblDistrito;
    private javax.swing.JLabel lblDomicilio;
    private javax.swing.JLabel lblEmail;
    private javax.swing.JLabel lblEstado;
    private javax.swing.JLabel lblEstadoCivil;
    private javax.swing.JLabel lblEstadoDetalle;
    private javax.swing.JLabel lblFechaNacimiento;
    private javax.swing.JLabel lblMaterno;
    private javax.swing.JLabel lblMaternoDetalle;
    private javax.swing.JLabel lblNombres;
    private javax.swing.JLabel lblNombresDetalle;
    private javax.swing.JLabel lblPaterno;
    private javax.swing.JLabel lblPaternoDetalle;
    private javax.swing.JLabel lblProvincia;
    private javax.swing.JLabel lblSexo;
    private javax.swing.JLabel lblTelefono;
    private javax.swing.JLabel lblUsuario;
    private javax.swing.JPanel pnlBuscar;
    private javax.swing.JPanel pnlCriterios;
    private javax.swing.JTextField txtDNI;
    private javax.swing.JTextField txtDomicilio;
    private javax.swing.JTextField txtEmail;
    private javax.swing.JTextField txtMaterno;
    private javax.swing.JTextField txtMaternoDetalle;
    private javax.swing.JTextField txtNombres;
    private javax.swing.JTextField txtNombresDetalle;
    private javax.swing.JTextField txtPaterno;
    private javax.swing.JTextField txtPaternoDetalle;
    private javax.swing.JTextField txtTelefono;
    private javax.swing.JTextField txtUsuario;
    // End of variables declaration//GEN-END:variables
}
