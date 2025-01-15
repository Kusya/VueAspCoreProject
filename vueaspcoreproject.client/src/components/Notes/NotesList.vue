<script lang="ts">
import { defineComponent } from "vue";

type Notes = {
  id: number;
  name: string;
  content: string;
  color: string;
}[];

interface Data {
  loading: boolean;
  post: null | Notes;
}

export default defineComponent({
  data(): Data {
    return {
      loading: false,
      post: null,
    };
  },
  created() {this.fetchData();},
  watch: {
    $route: "fetchData",
  },
  methods: {
    fetchData(): void {      
      this.post = null;
      this.loading = true;
      fetch("note")
        .then((r) => r.json())
        .then((json) => {
          this.post = json as Notes;
          this.loading = false;
          return;
        });
    },
  },
})
</script>
<template>
  <div class="noteForm">
    <div class="noteTitle">Do write a learning plan</div>
    <div class="noteContent">
      <ul>
        <li>find designer curces on udemy and courcera</li>
        <li>find PM curces on -||-</li>
      </ul>
    </div>
  </div>
</template>
<style>
body {
  background-color: powderblue;
}
h1 {
  color: blue;
}
p {
  color: red;
}
.noteForm {
  display: block;
  background-color: yellow;
  height: 300px;
  width: 300px;
  border: 1px solid #ccc;
  border-radius: 30px 0 0 0;
}
.noteTitle {
  font-size: 20px;
  padding: 20px 10px 0 40px;
}
.noteContent {
  font-family: system-ui;
  padding: 0 20px 0 0;
}
</style>
