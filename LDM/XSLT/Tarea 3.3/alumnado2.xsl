<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <!-- Título de la página -->
                <h2 style="text-align:center">Datos personales</h2>
                <!-- Tabla de alumnos -->
                <table border="1" cellpadding="5" cellspacing="0" style="width:40%; border-collapse:collapse; margin-left: 30%">
                    <tr bgcolor="grey">
                        <th style="text-align:center">Alumno</th>
                        <th style="text-align:center">Población</th>
                        <th style="text-align:center">Tfno</th>
                        <th style="text-align:center">Fecha Nacimiento</th>
                    </tr>
                    <!-- Iteración sobre los datos personales de cada alumno del archivo alumando.xml con localidad igual a Catarroja-->
                     <xsl:for-each select="alumnado/alumno[poblacion='Catarroja']">
                        <xsl:sort select="nombre" /> <!-- Ordenar a los alumnos alfabéticamente-->
                        <tr>
                            <td style="text-align:center"><xsl:value-of select="nombre"/></td>
                            <td style="text-align:center"><xsl:value-of select="poblacion"/></td>
                            <td style="text-align:center"><xsl:value-of select="tfno"/></td>
                            <td style="text-align:center"><xsl:value-of select="f_nacimiento"/></td>
                        </tr>
                     </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>