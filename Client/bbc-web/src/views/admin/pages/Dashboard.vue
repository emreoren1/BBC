<template>
  <div class="about">
    <h1>Dashboard</h1>
  
     <v-btn @click.stop="changeFooter()" icon>
        <v-icon>mdi-application</v-icon>
      </v-btn>
  </div>
</template>

<script>
export default {
  name: "Dashboard",
  created(){
    this.$store.commit("SET_panelText", "Dashboard");
  },
  methods:{
    changeFooter(){
      this.$store.commit("SET_footer","yeni footer");
    }
  }
};
</script>
