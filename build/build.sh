#!/bin/sh
yum update -y
yum install curl -y
curl -sL https://rpm.nodesource.com/setup_10.x | bash -
yum install nodejs -y

rm -rf /app/*
dotnet publish /opt/MODiX/Modix.sln -c Release -r linux-x64 --self-contained -o /app