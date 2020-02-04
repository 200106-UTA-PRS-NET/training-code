# a Dockerfile is a recipe for building a Docker image

# general things you do in a Dockerfile:
# 1. choose your base image
#      you can get your base image (a) locally, or (b) from a registry,
#            such as Docker Hub
# 2. copy files from outside the image into the image
# 3. run terminal commands inside the image (e.g. installing things)
# 4. add configuration/environment variables


# to set the base image, we do this:

#         registry         repo/image      tag
# (by default, docker hub)              (latest)
#    |                |                  |     |
FROM mcr.microsoft.com/dotnet/core/runtime:3.1

# the runtime needs assemblies already compiled,
# so, before "docker build", run:
#   dotnet publish -o publish

# take the contents of the publish folder outside docker...
#  ... and put them in a new folder /app at the root of inside Docker's file system.
COPY publish/ /app
