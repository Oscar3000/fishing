FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

#ENV ASPNETCORE_URLS https://*:5000

#global tool
RUN dotnet tool install --global dotnet-ef 
ENV PATH="/root/.dotnet/tools:${PATH}"
RUN echo $PATH

WORKDIR /app

#copy csproj and restore as distinct layers
COPY ./fishingApi/*.csproj ./
RUN dotnet restore

#copy everything else and build
COPY ./fishingApi/ ./

RUN ls

RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh