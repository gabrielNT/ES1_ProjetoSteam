@echo off
SET DatabaseFileName=DBSteam
 
ECHO Generating code for %DatabaseFileName%
ECHO Generating create script 'CreateDatabaseSchema.sql'
 
"C:\Program Files (x86)\Microsoft SQL Server\90\Tools\Publishing\SqlPubWiz.exe" script -C "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DBSteam.mdf;Integrated Security=True"  -noschemaqualify -schemaonly -nodropexisting -f CreateDatabaseSchema.sql