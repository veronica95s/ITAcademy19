<script setup lang="ts">
    const emit = defineEmits(['evento']);
</script>


<template>
    <h2>Meu Componente</h2>
    <button type="button" @click="emit('evento')">Dispare Evento</button>
</template>