package Control;

import Model.Empleado;
import com.mysql.jdbc.Statement;
import java.io.BufferedReader;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Properties;

public class GestorBD implements Serializable {

    ArrayList<Empleado> empleados = new ArrayList<Empleado>();

    public GestorBD() {
    }

    public Connection obtenerConexion() throws Exception {
        String url = "jdbc:mysql://localhost:3306/ejemplobd";
        String login = "root";
        String password = "josue";

        Connection con = null;

        Class.forName("com.mysql.jdbc.Driver").newInstance();
        con = DriverManager.getConnection(url, login, password);

        return con;
    }

    public void agregar() {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String cadena, nombre, paterno, materno, dni;
        int id, codigo;
        double sueldo;

        try {
            Connection con = obtenerConexion();

            if (con != null) {

                int rows_updated = 0;

                PreparedStatement stmt = con.prepareStatement("INSERT INTO Empleado (idempleado, nombre, paterno, materno, dni, codigo, sueldo) " +
                        "VALUES (?,?,?,?,?,?,?)");
                System.out.print("Ingrese IdEmpleado: ");
                cadena = br.readLine();
                id = Integer.parseInt(cadena);
                stmt.setInt(1, id); // IDEmpleado
                System.out.print("Ingrese Nombre: ");
                nombre = br.readLine();
                stmt.setString(2, nombre); // Nombre
                System.out.print("Ingrese Ap. Paterno: ");
                paterno = br.readLine();
                stmt.setString(3, paterno); // Paterno
                System.out.print("Ingrese Ap. Materno: ");
                materno = br.readLine();
                stmt.setString(4, materno); // Materno
                System.out.print("Ingrese DNI: ");
                dni = br.readLine();
                stmt.setString(5, dni); // DNI
                System.out.print("Ingrese Codigo: ");
                cadena = br.readLine();
                codigo = Integer.parseInt(cadena);
                stmt.setInt(6, codigo); // Codigo
                System.out.print("Ingrese Salario: ");
                cadena = br.readLine();
                sueldo = Double.parseDouble(cadena);
                stmt.setDouble(7, sueldo); // Sueldo

                rows_updated = stmt.executeUpdate();

                System.out.println("Se agrego " + rows_updated + "Empleado");

                stmt.close();
                con.close();
            }
        } catch (Exception e) {
            System.out.println("Error 1");
        }
    }

    public void eliminar() {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String cadena;

        try {
            Connection con = obtenerConexion();

            if (con != null) {
                Statement stmt = (Statement) con.createStatement();
                System.out.print("Ingrese Codigo del Empleado a eliminar: ");
                cadena = br.readLine();
                int row2 = stmt.executeUpdate("DELETE FROM Empleado WHERE Codigo = " + cadena);

                stmt.close();
                con.close();
            }
        } catch (Exception e) {
            System.out.println("Error");
        }
    }

    public void consultar() {
        try {
            Connection con = obtenerConexion();

            if (con != null) {
                Statement stmt = (Statement) con.createStatement();
                ResultSet res = stmt.executeQuery("SELECT * FROM Empleado");
                System.out.println("DATOS: (Id/Nombre/Ap.Paterno/Ap.Materno/DNI/Codigo/Suelgo)");
                System.out.println("==========================================================");

                System.out.println();

                while (res.next()) {
                    int id = res.getInt("idempleado");
                    String nombre = res.getString("nombre");
                    String paterno = res.getString("paterno");
                    String materno = res.getString("materno");
                    String dni = res.getString("dni");
                    int codigo = res.getInt("codigo");
                    double sueldo = res.getDouble("sueldo");
                    System.out.println(id + "/" + nombre + "/" + paterno + "/" + materno + "/" + dni + "/" + codigo + "/" + sueldo);
                }
                res.close();
                stmt.close();
                con.close();
            }
        } catch (Exception e) {
            System.out.println("Error");
        }
    }

    public String consultarPorNombre() {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String nombreBuscado = "";
        Connection con = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try {

            //1. Se registra el driver de BD de tipo nativo que nos ofrece el creador del motor de BD (Driver JDBC de MySQL)         
            com.mysql.jdbc.Driver myDriver = new com.mysql.jdbc.Driver();
            //2. Se obtiene la conexión a la BD utilizando el JDBC URL, user y password de BD
            Properties properties = new Properties();
            properties.put("user", "root");
            properties.put("password", "josue");
            con = myDriver.connect("jdbc:mysql://127.0.0.1:3306/ejemplobd", properties);
            //3. Se prepara la sentencia
            System.out.print("Ingrese el Nombre del Empleado a buscar: ");
            nombreBuscado = br.readLine();
            pstmt = con.prepareStatement("SELECT * FROM Empleado WHERE Nombre = '" + nombreBuscado + "'");
            //4. Se ejecuta la sentencia
            rs = pstmt.executeQuery();
            //5. Se evaluan los resultados
            while (rs.next()) {
                int id = rs.getInt("idempleado");
                String nombre = rs.getString("nombre");
                String paterno = rs.getString("paterno");
                String materno = rs.getString("materno");
                String dni = rs.getString("dni");
                int codigo = rs.getInt("codigo");
                double sueldo = rs.getDouble("sueldo");
                System.out.println(id + "/" + nombre + "/" + paterno + "/" + materno + "/" + dni + "/" + codigo + "/" + sueldo);
            }

            rs.close();
            pstmt.close();
            con.close();
        } catch (Exception e) {
            e.printStackTrace();
        }

        return nombreBuscado;
    }

    public void guardarEnArchivo(String nombreBuscado) {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try {

            conn = obtenerConexion();
            pstmt = conn.prepareStatement("SELECT * FROM Empleado WHERE Nombre = '" + nombreBuscado + "'");
            rs = pstmt.executeQuery();

            while (rs.next()) {
                Empleado empleado = new Empleado();
                empleado.setNombre(rs.getString("nombre"));
                empleado.setPaterno(rs.getString("paterno"));
                empleado.setMaterno(rs.getString("materno"));
                empleado.setDNI(rs.getString("dni"));
                empleado.setCodigo(rs.getInt("codigo"));
                empleado.setSueldo(rs.getDouble("sueldo"));
                empleados.add(empleado);
            }

            rs.close();
            pstmt.close();
            conn.close();
        } catch (Exception e) {
            System.out.println("Error");
        }

        try {
            System.out.print("Guardar documento como?: ");
            String nombre = br.readLine();
            String ruta = "src/Files/" + nombre + ".bin";

            FileOutputStream fos = new FileOutputStream(ruta);
            ObjectOutputStream oos = new ObjectOutputStream(fos);
            oos.writeObject(this);
            oos.close();
            fos.close();

        } catch (Exception e) {
            System.out.println("Ocurrio un error al guardar el documento...");
        }
    }

    public ArrayList<Empleado> getEmpleados() {
        return this.empleados;
    }
}
