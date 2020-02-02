class TodoAjaxService {
    constructor() {
        this.url = "http://localhost:54994/api/todos";
    }

    getTodos = callback => {
        $.ajax({
            url: this.url,
            method: 'get',
            success: callback
        });
    }

    addTodo = (todo, callback) => {
        $.ajax({
            url: this.url,
            method: 'post',
            success: callback,
            data: todo
        });
    }

    putTodo = (todo, callback) => {
        $.ajax({
            url: this.url + `/${todo.Id}`,
            method: 'put',
            success: callback,
            data: todo
        });
    }

    deleteTodo = (id, callback) => {
        $.ajax({
            url: this.url + `/${id}`,
            method: 'delete',
            success: callback
        });
    }

    completeTodoAndPut = (todo, callback) => {
        todo.IsCompleted = true;

        $.ajax({
            url: this.url + `/${todo.Id}`,
            method: 'put',
            success: callback,
            data: todo
        });
    }
}