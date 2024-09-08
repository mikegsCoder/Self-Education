export function timeFormatter(seconds) {
  if (Number.isNaN(seconds) || seconds < 0)
    return '';
  const date = new Date(seconds);

  const formatter = new Intl.DateTimeFormat('en', {
    minute: '2-digit',
    second: '2-digit',
    timeZone: 'UTC',
  });

  return formatter.format(date);
}
