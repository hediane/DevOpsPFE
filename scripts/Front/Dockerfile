FROM node:16.10-alpine AS build
WORKDIR /app

COPY package.json package-lock.json ./
#COPY --from=build dist/DevOpsFront /usr/share/nginx/html
RUN npm install -g npm@8.11.0 -g @angular/cli 
RUN npm install
COPY ./DevOpsFront .
#RUN npm run build
RUN ng build --prod

FROM nginx:latest
COPY ./nginx/nginx.conf /etc/nginx/nginx.conf
RUN rm -rf /usr/share/nginx/html/*
COPY --from=build /app/dist /usr/share/nginx/html
