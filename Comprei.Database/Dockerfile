FROM mcr.microsoft.com/mssql/server:2019-latest

ENV SA_PASSWORD=Compreipass01
ENV ACCEPT_EULA=Y

# Copy SQL Server script to container
#COPY setup.sql /opt/setup.sql

# Grant permissions for the script to execute
#RUN chmod +x /opt/setup.sql

CMD /opt/mssql/bin/sqlservr #& /opt/setup.sh