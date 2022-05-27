FROM nginx:latest
RUN rm -rf RUN rm -rf /etc/nginx/nginx.conf
COPY /nginx/nginx.conf /etc/nginx/nginx.conf
COPY --from=build ./DevOpsFront/dist/DevOpsFront /usr/share/nginx/html
