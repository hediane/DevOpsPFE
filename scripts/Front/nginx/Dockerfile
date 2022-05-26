FROM nginx:alpine
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=node /app/dist /usr/share/nginx/html
#COPY --from=builder /app-ui/dist /usr/share/nginx/html



