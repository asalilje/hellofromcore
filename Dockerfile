FROM microsoft/dotnet:2.0-sdk as builder  
ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

RUN mkdir -p /root/src  
WORKDIR /root/src  
COPY . app 
WORKDIR /root/src/app

RUN dotnet restore ./HelloFromCore.csproj  
RUN dotnet publish -c release -o published -r linux-arm

FROM microsoft/dotnet:2.0.0-runtime-stretch-arm32v7

WORKDIR /root/  
COPY --from=builder /root/src/app/published .
EXPOSE 3001
CMD ["dotnet", "./HelloFromCore.dll"]