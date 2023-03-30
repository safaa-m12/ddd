

* {
    box-sizing: border-box;
}

body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

.heading-title {
    color: black;
    /* text-align: center; */
}

.container {
    border: none;
	margin-left: auto;
	margin-right: auto;
	margin-top: 10px;
	margin-bottom: 10px;
	padding: 10px;
}

section {
    border:	1px solid black;
    background-color: gray;
    border-radius: 0.5rem;
	width: 100%;
	height: 200px;
	color: black;
	position: relative;
    overflow: auto;
}

#chicken {
    border: 1px solid black;
    border-radius: 0.5rem;
	text-align: center;
    width: 30%;
	margin-left: 70%;
	font-weight: bold;
	font-size: 125%;
	margin-bottom: 0;
	margin-top: 0;
	padding: 5px;
	background-color: hsl(1, 42%, 72%);
}

#beef {
    border: 1px solid black;
    border-radius: 0.5rem;
	text-align: center;
    width: 30%;
	margin-left: 70%;
	font-weight: bold;
	font-size: 125%;
	margin-bottom: 0;
	margin-top: 0;
	padding: 5px;
	background-color: #C14643;
}

#sushi {
    border: 1px solid black;
    border-radius: 0.5rem;
	text-align: center;
    width: 30%;
	margin-left: 70%;
	font-weight: bold;
	font-size: 125%;
	margin-bottom: 0;
	margin-top: 0;
	padding: 5px;
	background-color: #E5D198;
}

p {
    padding: 15px;
    margin: 0;
}

/* Desktop view */
@media(min-width: 992px) {
    .box {
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-template-rows: 1fr;
        grid-auto-flow: row;
    }

    .item1 {
        grid-column: 1;
        grid-row: 1;
    }

    .item3 {
        grid-column: 3;
        grid-row: 1;
    }
}

/* Tablet view */
@media(min-width: 768px) and (max-width: 991px) {
    .box {
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        grid-template-rows: repeat(2, 1fr);
        grid-auto-flow: row;
    }

    .item1 {
        grid-column: 1 / 2;
        grid-row: 1 / 2;
    }

    .item2 {
        grid-column: 2 / 3;
        grid-row: 1 / 2;
    }

    .item3 {
        grid-column: 1 / 3;
        grid-row: 2 / 3;
    }

}

/* Mobile view */
@media (max-width: 768px) {
    .box {
        display: grid;
        grid-template-columns: 1fr;
        grid-template-rows: repeat(3, 1fr);
        grid-auto-flow: column;
    }

    .item1 {
        grid-column: 1;
        grid-row: 1 / 2;
    }

    .item2 {
        grid-column: 1;
        grid-row: 2 / 3;
    }

    .item3 {
        grid-column: 1;
        grid-row: 3 / 4;
    }
}

#nav-text a {
    text-align: center;
}