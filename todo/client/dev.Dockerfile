FROM node
WORKDIR /client
COPY . .
RUN npm i
CMD ["npm", "run", "dev", "--", "--host"]

# docker build . -t todo-client -f dev.Dockerfile
# docker run -p 8080:8080 todo-client
