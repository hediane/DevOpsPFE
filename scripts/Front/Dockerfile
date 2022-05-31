FROM node:16.10-alpine AS build
WORKDIR /app
EXPOSE 4200
COPY package.json package-lock.json ./
#COPY --from=build dist/DevOpsFront /usr/share/nginx/html
RUN npm install -g npm@8.11.0 -g @angular/cli 
RUN npm install
COPY ./DevOpsFront .
#RUN npm run build
RUN ng build --prod
CMD ng serve

FROM nginx:latest
RUN rm -rf RUN rm -rf /etc/nginx/nginx.conf
COPY /nginx/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/dist/DevOpsFront /usr/share/nginx/html
ENTRYPOINT ["nginx", "-g", "daemon off;"]
