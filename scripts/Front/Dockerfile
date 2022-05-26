FROM node:16.0-alpine AS build
EXPOSE 4200
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN npm run build
