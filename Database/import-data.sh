#wait for the SQL Server to come up
# echo "Waiting 90 sec. for SQL Server to come up..."
# sleep 90s

#run the setup script to create the DB and the schema in the DB
echo "Creating database and schema..."
/opt/mssql-tools/bin/sqlcmd -S db -U sa -P Top-Secret -d master -i /usr/src/app/setup.sql
