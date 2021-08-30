#!/bin/bash
FILENAME='tablas.txt'
LINE=0
FILENAMECAMPOS='tabla_final.csv'
LINECAMPOS=0
LINENOMBRES=0
CAMPOS=()
NOMBRES=()
FILES=()
while read text; do
FILES[$LINE]=${text//$'\r'}
LINE=$((LINE+1))
done < $FILENAME
for i in "${FILES[@]}"
do
    echo "using System;" >> $i.cs
    echo "using System.ComponentModel.DataAnnotations;" >> $i.cs
    echo "namespace sniiv.Models" >> $i.cs
    echo "{" >> $i.cs
    echo "	public class $i" >> $i.cs
    echo "	{" >> $i.cs
done
while IFS=, read -r field1 field2
do
    CAMPOS[$LINECAMPOS]=${field1//$'\r'}
    NOMBRES[$LINECAMPOS]=${field2//$'\r'}
    LINECAMPOS=$((LINECAMPOS+1))
done < campos.csv

for i in "${CAMPOS[@]}"
do
echo $i
    echo "		${NOMBRES[$LINENOMBRES]}" >>$i.cs
    LINENOMBRES=$((LINENOMBRES+1))
done

for i in "${FILES[@]}"
do
echo " " >> $i.cs
    echo "	}" >> $i.cs
    echo "}" >> $i.cs
    echo $i
done
