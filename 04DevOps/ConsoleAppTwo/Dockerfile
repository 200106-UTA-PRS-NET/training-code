# 1. choose the base image
#   we want a well-supported, often-updated image
#   and we want one with all of the dependencies
#   that go into what we want to happen in the image/container

# there's often a tradeoff there

# to compile .NET code, we need the .NET Core SDK.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# WORKDIR sets the current directory inside the image,
# creating it if necessary
WORKDIR /app

# copy everything outside the image, into /app
COPY . ./

# run commands as part of building the docker image
RUN dotnet build -c Release

CMD dotnet run -c Release
# there is a technique called multi-stage build which is a better way to do this
