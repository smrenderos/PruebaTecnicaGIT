<h1 id="prueba-técnica-git">Prueba Técnica GIT</h1>
<h2 id="información">Información</h2>
<p>Prueba técnica desarrollada utilizando las siguientes herramientas:</p>
<ul>
<li>IDE: Visual Studio 2022.</li>
<li>Lenguaje: Visual Basic .NET Framework.</li>
<li>Base de Datos: Oracle Database 21c Express Edition.</li>
</ul>
<h2 id="database-dump">Database dump</h2>
<p>Instalar Oracle Database 21c Express Edition o versión anterior de oracle y ejecutar el script sql de la carpeta “database dump/database_dump.sql”.</p>
<blockquote>
<p><strong>Nota:</strong> La solución utiliza el string de conexión:<br>
OracleConnection(“User ID=system;Password=123456;Data Source=localhost:1521/XE;”)<br>
Se puede editar modificando el modulo Conexion.vb ubicado en el directorio PruebaTecnicaGIT</p>
</blockquote>
<h2 id="instalar-paquete-oracle.manageddataaccess">Instalar paquete Oracle.ManagedDataAccess</h2>
<p>En el IDE de Visual Studio instalar paquete Oracle.ManagedDataAccess a través del administrador de paquetes NuGet.</p>
<h2 id="manejo-de-usuarios">Manejo de Usuarios</h2>
<p>La solución utiliza los siguientes perfiles de usuario:</p>
<blockquote>
<p><strong>Nota:</strong> Luego de ejecución con éxito del script database_dump.sql</p>
</blockquote>
<ul>
<li>Administrador<br>
Usuario: admin<br>
Contraseña: admin</li>
<li>Empleado<br>
Usuario: login<br>
Contraseña: login</li>
</ul>
