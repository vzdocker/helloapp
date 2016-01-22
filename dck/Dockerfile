FROM microsoft/aspnet
COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

EXPOSE 6000
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
