# !/bin/sh 

sudo docker pull microsoft/mssql-server-linux
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=test123!!' -p 1433:1433 -d microsoft/mssql-server-linux