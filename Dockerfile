#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN echo "Current working directory is: %cd%" && dir
COPY ["GraphQL_Example/GraphQL_Example.csproj", "GraphQL_Example/"]
COPY ["BLL/BLL.csproj", "BLL/"]
COPY ["DAL/DAL.csproj", "DAL/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "GraphQL_Example/GraphQL_Example.csproj"
COPY . .
WORKDIR "/src/GraphQL_Example"
RUN dotnet build "GraphQL_Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GraphQL_Example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphQL_Example.dll"]